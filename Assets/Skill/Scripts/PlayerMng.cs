using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMng : MonoBehaviour
{
    CharacterController controller;

    Vector3 moveDir;

    [Header("Player State")]
    [SerializeField] float speed;
    [SerializeField] float jumpPower;
    [SerializeField] float rotSpeed;
    float gravity;
    float viewDirX;

    public static bool isDialog;

    [Header("Player Level")]
    public int level;
    public float exp;
    public float maxExp;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = 10.0f;
        jumpPower = 5.0f;
        gravity = 10.0f;
        rotSpeed = 2.0f;
        level = 1;
        maxExp = 10.0f;
    }

    void Update()
    {
        if (!isDialog)
        {
            Move();
            Skill();
        }
    }

    float h => Input.GetAxis("Horizontal");
    float v => Input.GetAxis("Vertical");

    void Move()
    {
        viewDirX += Input.GetAxis("Mouse X") * rotSpeed;
        if (controller.isGrounded)
        {
            moveDir = new Vector3(h, 0f, v);
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpPower;
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
                speed = 20.0f;
            if (Input.GetKeyUp(KeyCode.LeftShift))
                speed = 10.0f;
        }
        transform.rotation = Quaternion.Euler(0f, viewDirX, 0f);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    void Skill()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            skill_1();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            skill_2();
        if (Input.GetKeyDown(KeyCode.Alpha3))
            skill_3();
        if (Input.GetKeyDown(KeyCode.Alpha4))
            skill_4();
        if (Input.GetKeyDown(KeyCode.Alpha5))
            skill_5();
    }

    public virtual void skill_1() { }
    public virtual void skill_2() { }
    public virtual void skill_3() { }
    public virtual void skill_4() { }
    public virtual void skill_5() { }
}
