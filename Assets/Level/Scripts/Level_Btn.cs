using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Btn : MonoBehaviour
{
    [SerializeField] LevelMng levelMng;
    [SerializeField] Level_Player playerSc;

    public void LevelUpBtn()
    {
        playerSc.level++;
        levelMng.LevelUpEvent(playerSc.level);
        
    }

    public void AddExpBtn_1()
    {
        playerSc.exp += 1.0f;
        levelMng.LevelTextSetting();
        if (playerSc.exp >= playerSc.maxExp)
        {
            playerSc.level++;
            levelMng.LevelUpEvent(playerSc.level);
        }
    }

    public void AddExpBtn_5()
    {
        playerSc.exp += 5.0f;
        levelMng.LevelTextSetting();
        if (playerSc.exp >= playerSc.maxExp)
        {
            playerSc.level++;
            levelMng.LevelUpEvent(playerSc.level);
        }
    }

    public void AddExpBtn_10()
    {
        playerSc.exp += 10.0f;
        levelMng.LevelTextSetting();
        if (playerSc.exp >= playerSc.maxExp)
        {
            playerSc.level++;
            levelMng.LevelUpEvent(playerSc.level);
        }
    }
}
