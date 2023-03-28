using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : PlayerMng
{
    protected override void Start()
    {
        base.Start();
        speed = 10.0f;
        jumpPower = 5.0f;
        attackDelay = 1.0f;
    }
    public override void basic_attack()
    {
        Debug.Log("Warrior basic Attack");
    }
    public override void skill_1()
    {
        Debug.Log("Warrior skill 1");
    }
    public override void skill_2()
    {
        Debug.Log("Warrior skill 2");
    }
    public override void skill_3()
    {
        Debug.Log("Warrior skill 3");
    }
    public override void skill_4()
    {
        Debug.Log("Warrior skill 4");
    }
    public override void skill_5()
    {
        Debug.Log("Warrior skill 5");
    }
}
