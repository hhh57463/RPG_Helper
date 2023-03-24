using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Player : MonoBehaviour
{
    [Header("Player Level")]
    public int level;
    public float exp;
    public float maxExp;

    void Start()
    {    
        level = 1;
        maxExp = 10.0f;
    }
}
