using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _JumpForce = 400f;                          // jump 高度
    public LayerMask _GroundLayers;                          // 设置那些是 ground
    public LayerMask _TrapLayers;                            // 陷阱 layer
    [Range(0, .3f)] public float _MovementSmoothing = .05f;  // How much to smooth out the movement

    private Rigidbody _Rigidbody;
    private SphereCollider _GroundCheck;
    private Vector3 _Velocity = Vector3.zero;                // 玩家移动的速度


    private void Awake()
    {
        _Rigidbody = GetComponent<Rigidbody>();
        _GroundCheck = GetComponent<SphereCollider>();
    }

    public bool m_IsGround() // 判断是否碰撞到了带有 Ground layer 的 GameObject
    {
        return Physics.CheckCapsule(_GroundCheck.bounds.center, new Vector3(_GroundCheck.bounds.center.x, _GroundCheck.bounds.min.y, _GroundCheck.bounds.center.z),
            _GroundCheck.radius * 0.9f, _GroundLayers);
    }

    public bool m_IsTrap()    // 判断是否碰撞到了带有 Trap  layer 的 GameObject
    {
        return Physics.CheckSphere(_GroundCheck.bounds.center, _GroundCheck.radius, _TrapLayers);
    }

    public void Move(float hmove, float vmove, bool jump)
    {
        // 用设置 target的方式来移动 player(间接设置 player 的最高移动速度)
        Vector3 targetVelocity = new Vector3(hmove * 10f, _Rigidbody.velocity.y, vmove * 10f);
        // 使 player 移动更加平滑
        _Rigidbody.velocity = Vector3.SmoothDamp(_Rigidbody.velocity, targetVelocity, ref _Velocity, _MovementSmoothing);


        // 如果 player jump
        if (jump)
        {
            _Rigidbody.AddForce(_JumpForce * Vector3.up);
        }
    }
}
