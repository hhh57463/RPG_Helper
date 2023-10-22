using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    CharacterController controller;

    Vector3 moveDir;

    [Header("Player State")]
    [SerializeField] float speed;
    [SerializeField] float jumpPower;
    [SerializeField] float rotSpeed;
    float gravity;
    float viewDirX;

    public static bool isDialog;

    void Start()
    {
        if (Manager.I != null)
            Manager.I.GetPlayerTransform(Manager.I.playerName);
        controller = GetComponent<CharacterController>();
        speed = 10.0f;
        jumpPower = 5.0f;
        gravity = 10.0f;
        rotSpeed = 2.0f;
    }

    void Update()
    {
        if (!isDialog)
            Move();
    }

    float h => Input.GetAxis("Horizontal");
    float v => Input.GetAxis("Vertical");

    void Move()
    {
        viewDirX += Input.GetAxis("Mouse X") * rotSpeed;
        if (controller.isGrounded)
        {
            moveDir = new Vector3(h, 0f, v);
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpPower;
            }
        }
        transform.rotation = Quaternion.Euler(0f, viewDirX, 0f);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}
