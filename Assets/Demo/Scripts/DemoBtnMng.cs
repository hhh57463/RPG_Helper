using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBtnMng : MonoBehaviour
{
    [SerializeField] GameObject JobObj;
    [SerializeField] GameObject LevelObj;
    public void SelectJob(int num)
    {
        DemoMng.I.SpawnCharactor(num);
        JobObj.SetActive(false);
        LevelObj.SetActive(true);
    }
}
