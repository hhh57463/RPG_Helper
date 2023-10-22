using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager instance = null;

    public static Manager I
    {
        get
        {
            if (instance.Equals(null))
            {
                Debug.Log("instance is null");
            }
            return instance;
        }
    }

    [Header("Player Information")]
    public string playerName;
    public Transform playerTr;

    void Awake()
    {
        instance = this;
        ///////////////////////////////////////
        //GetPlayerTransform();
        ///////////////////////////////////////
    }

    /// <summary>
    /// Call to desired location (Current location: Awake)
    /// str: Player 
    /// </summary>
    public void GetPlayerTransform(string str)
    {
        playerTr = GameObject.Find(str).GetComponent<Transform>();            // Search Method: GameObject.name
        //playerTr = GameObject.FindGameObjectWithTag(str);                   // Search Method: Tag
    }
}
