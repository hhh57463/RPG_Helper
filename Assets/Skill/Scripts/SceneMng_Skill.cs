using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JOB
{
    WORRIOR,
    WIZARD,
    THIEF
}
public class SceneMng_Skill : MonoBehaviour
{
    [Header("Select Job")]
    [Tooltip("Select Job And Start")]
    [SerializeField] JOB job;

    [SerializeField] Cinemachine.CinemachineVirtualCamera vCam;

    [SerializeField] GameObject[] charactors;
    void Start()
    {
        Transform temp = Instantiate(charactors[(int)job], new Vector3(0f, 1f, 0f), Quaternion.identity).GetComponent<Transform>();
        vCam.Follow = temp;
        vCam.LookAt = temp;
    }
}
