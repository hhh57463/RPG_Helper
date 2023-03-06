using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public NpcData npcData;
    public GameObject Dialog;

    private void OnCollisionStay(Collision col)
    {
        if(col.transform.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Dialog.SetActive(true);
            }
        }
    }
}
