using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Btn : MonoBehaviour
{
    [SerializeField] LevelMng levelMng;
    [SerializeField] Level_Player playerSc;
    public void LevelUpBtn()
    {
        if (playerSc.level < 10)
        {
            playerSc.level++;
            levelMng.LevelUpEvent(playerSc.level);
        }
    }
    public void AddExpBtn_1()
    {
        if (playerSc.exp + 1.0f <= playerSc.maxExp)
        {
            playerSc.exp += 1.0f;
            levelMng.LevelTextSetting();
        }
    }
    public void AddExpBtn_5()
    {
        if (playerSc.exp + 5.0f <= playerSc.maxExp)
        {
            playerSc.exp += 5.0f;
            levelMng.LevelTextSetting();
        }
    }
    public void AddExpBtn_10()
    {
        if (playerSc.exp + 10.0f <= playerSc.maxExp)
        {
            playerSc.exp += 10.0f;
            levelMng.LevelTextSetting();
        }
    }
}
