using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JOB
{
    WORRIOR,
    WIZARD,
    THIEF
}
public class SceneMng : MonoBehaviour
{
    [Header("Select Job")]
    [Tooltip("Select Job And Start")]
    [SerializeField] JOB job;

    [SerializeField] Cinemachine.CinemachineVirtualCamera vCam;

    [SerializeField] GameObject[] charactors;

    public static Transform player;
    void Awake()
    {
        player = Instantiate(charactors[(int)job], new Vector3(0f, 1f, 0f), Quaternion.identity).GetComponent<Transform>();
        vCam.Follow = player;
        vCam.LookAt = player;
    }
}
