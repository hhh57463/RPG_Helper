using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Tooltip("[Monster Type]\n1: In Range Move Monster\n2: Esacape Range, revert point Monster\n3: In Range Follow Monster")]
    [SerializeField] int monsterType;
    [Tooltip("[Monster Patern]\n0: Comback SpawnPoint\n1: Stand\n2: Move\n3: Follow Player")]
    [SerializeField] int patern;
    [SerializeField] float speed;
    float moveSpeed;
    Vector3 spawnLocalPos;
    Vector3 spawnWorldPos;
    Vector3 targetPos;

    float spawnRadius;

    void Start()
    {
        spawnLocalPos = transform.localPosition;
        spawnWorldPos = transform.position;
        speed = 11.0f;
        spawnRadius = 30f;
        StartCoroutine("Thinking");
    }

    void Update()
    {
        switch (monsterType)
        {
            case 1:
                MonsterType1();
                break;
            case 2:
                MonsterType2();
                break;
            case 3:
                MonsterType3();
                break;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StopCoroutine("Thinking");
            transform.localPosition = spawnLocalPos;
            speed = 11.0f;
            StartCoroutine("Thinking");
        }
    }

    void MonsterType1()
    {
        if (Vector3.Distance(spawnLocalPos, transform.localPosition) >= spawnRadius)
        {
            StopCoroutine("Thinking");
            patern = 0;
        }

        PaternAction();

        transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPos, moveSpeed * Time.deltaTime);
        if (transform.localPosition == targetPos)
            MovePos();
    }
    [Header("Chase Range")]
    [SerializeField] float chaseRadius = 30f;
    void MonsterType2()
    {
        if (Vector3.Distance(spawnLocalPos, transform.localPosition) >= spawnRadius)
        {
            StopCoroutine("Thinking");
            patern = 0;
        }
        if (Vector3.Distance(spawnWorldPos, SceneMng.player.transform.position) <= chaseRadius)
        {
            StopCoroutine("Thinking");
            patern = 3;
        }

        PaternAction();

        if (patern == 3)
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        else
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPos, moveSpeed * Time.deltaTime);
        if (transform.localPosition == targetPos)
            MovePos();
    }

    bool isChasing = false;
    void MonsterType3()
    {
        if (Vector3.Distance(SceneMng.player.transform.position, transform.position) <= chaseRadius)
        {
            StopCoroutine("Thinking");
            isChasing = true;
            patern = 3;
        }
        if (isChasing && Vector3.Distance(SceneMng.player.transform.position, transform.position) >= chaseRadius)
        {
            if (Vector3.Distance(spawnLocalPos, transform.localPosition) >= spawnRadius)
            {
                isChasing = false;
                patern = 0;
            }
        }
        PaternAction();
        if (patern == 3)
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        else
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPos, moveSpeed * Time.deltaTime);
        if (transform.localPosition == targetPos)
            MovePos();
    }

    IEnumerator Thinking()
    {
        SelectPatern();
        yield return new WaitForSeconds(10.0f);
        StartCoroutine("Thinking");
    }

    void MovePos()
    {
        targetPos = new Vector3(Random.Range(-25, 25), 1.5f, Random.Range(-25, 25));
        transform.LookAt(targetPos);
    }

    void SelectPatern()
    {
        patern = Random.Range(1, 3);
        if (patern == 2)
            MovePos();
    }

    void PaternAction()
    {
        switch (patern)
        {
            case 0:
                targetPos = spawnLocalPos;
                moveSpeed = speed;
                if (Vector3.Distance(spawnLocalPos, transform.localPosition) >= 1.0f)
                    StartCoroutine("Thinking");
                break;
            case 1:
                moveSpeed = 0f;
                break;
            case 2:
                moveSpeed = speed;
                break;
            case 3:
                targetPos = SceneMng.player.transform.position;
                break;
        }
    }
}
