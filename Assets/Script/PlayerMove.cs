using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public PlayerController PC;
    public float runSpeed = 40f;    // 移动速度

    float horizontalMove = 0f;      // 水平方向的移动速度
    float verticalMove = 0f;        // 竖直方向的移动速度 
    bool jump = false;              // 是否在 jump

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; // 获得水平方向的移动方向(Input.GetAxisRaw("Horizontal"))及速度(整个矢量值)
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;     // 获得竖直方向的移动方向(Input.GetAxisRaw("Vertical"))及速度(整个矢量值)

        if (Input.GetKeyDown(KeyCode.Space) && PC.m_IsGround())       // 按下 space 键且 player 在 ground 上时，jump 为 true，才可以跳
        {
            jump = true;
        }

        /*        Debug.Log("Player position:" + transform.position);*/
    }

    private void FixedUpdate()
    {

        PC.Move(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime, jump); // 整个移动函数
        jump = false;                                                                            // 重新修改 jump 为 false，不然就可以一直跳下去了
    }
}
