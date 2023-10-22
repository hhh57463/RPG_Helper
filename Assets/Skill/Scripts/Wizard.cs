using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : PlayerMng
{
    protected override void Start()
    {
        base.Start();
        if (Manager.I != null)
        {
            Manager.I.playerName = "Wizard(Clone)";
            Manager.I.GetPlayerTransform(Manager.I.playerName);
        }
        speed = 10.0f;
        jumpPower = 5.0f;
        attackDelay = 1.0f;
    }
    public override void basic_attack()
    {
        Debug.Log("Wizard basic Attack");
    }
    public override void skill_1()
    {
        Debug.Log("Wizard skill 1");
    }
    public override void skill_2()
    {
        Debug.Log("Wizard skill 2");
    }
    public override void skill_3()
    {
        Debug.Log("Wizard skill 3");
    }
    public override void skill_4()
    {
        Debug.Log("Wizard skill 4");
    }
    public override void skill_5()
    {
        Debug.Log("Wizard skill 5");
    }
}
