using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoMng : MonoBehaviour
{
    private static DemoMng _instance;
    public static DemoMng I
    {
        get
        {
            if (_instance.Equals(null))
            {
                Debug.Log("Instance is null");
                return null;
            }
            else
                return _instance;
        }
    }
    
    [SerializeField] JOB job;

    [SerializeField] Cinemachine.CinemachineVirtualCamera vCam;

    [SerializeField] GameObject[] charactors;
    public DemoLevelMng levelMng;

    public Transform player;
    
    void Awake()
    {
        _instance = this;
    }

    public void SpawnCharactor(int num)
    {
        job = (JOB)num;
        GameObject tmp = Instantiate(charactors[(int)job], new Vector3(0f, 1f, 0f), Quaternion.identity) as GameObject;
        player = tmp.GetComponent<Transform>();
        vCam.Follow = player;
        vCam.LookAt = player;
        levelMng.playerSc = tmp.GetComponent<PlayerMng>();
        levelMng.enabled = true;
    }
}
