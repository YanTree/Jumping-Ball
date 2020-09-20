using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTrigger : MonoBehaviour
{
    public float upSpeed = 20f;  // slide 的速度
    bool touchTrigger = false;   // 是否触发 Trigger

    GameObject _Slide;           // 其父对象 Slide

    private void Awake()
    {
        _Slide = transform.parent.gameObject; // 获取父对象
    }
    private void OnTriggerEnter()             // 当玩家触发 Slide Trigger
    {
        Debug.Log("Enter Slide Trigger!");
        touchTrigger = true;                  // touchTrigger 就为真
        FindObjectOfType<AudioManager>().Play("elevator");
    }

    bool toTop()                              // 判断 Slide 是否到达顶端
    {
        return _Slide.transform.position.y >= 0;
    }

    void MoveUp()                             // 向上移动 Slide
    {
        _Slide.transform.position += Vector3.up * upSpeed * Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        if (!toTop() && touchTrigger)
            MoveUp();
        else
            FindObjectOfType<AudioManager>().Stop("elevator");
    }
}
