using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : PlayerMng
{
    protected override void Start()
    {
        base.Start();
        speed = 15.0f;
        jumpPower = 7.5f;
        attackDelay = 0.5f;
    }
    public override void basic_attack()
    {
        Debug.Log("Thief basic Attack");
    }
    public override void skill_1()
    {
        Debug.Log("Thief skill 1");
    }
    public override void skill_2()
    {
        Debug.Log("Thief skill 2");
    }
    public override void skill_3()
    {
        Debug.Log("Thief skill 3");
    }
    public override void skill_4()
    {
        Debug.Log("Thief skill 4");
    }
    public override void skill_5()
    {
        Debug.Log("Thief skill 5");
    }
}