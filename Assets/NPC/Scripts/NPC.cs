using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Cinemachine;

public class NPC : MonoBehaviour
{
    public string npcName;
    [TextArea] public string[] npcDialog;
    public GameObject dialog;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI dialogText;
    [SerializeField] int dialogIdx;

    void DialogSetting(int idx)
    {
        dialogText.text = npcDialog[idx];
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (!Player.isDialog)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Player.isDialog = true;
                    
                    CamMng.vCam.Follow = transform;
                    CamMng.vCam.LookAt = transform;
                    CamMng.vCam.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.z = 10.0f;
                    npcNameText.text = npcName;
                    dialogIdx = 0;
                    dialog.SetActive(true);
                    DialogSetting(dialogIdx);
                }
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    if(dialogIdx < npcDialog.Length - 1)
                    {
                        DialogSetting(++dialogIdx);
                    }
                    else
                    {
                        dialog.SetActive(false);
                        Player.isDialog = false;
                        Transform playerTr = GameObject.Find("Player").transform;
                        CamMng.vCam.Follow = playerTr;
                        CamMng.vCam.LookAt = playerTr;
                        CamMng.vCam.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.z = -10.0f;
                    }
                }
            }
        }
    }
}
