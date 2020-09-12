using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSlide : MonoBehaviour
{
    public float radiusSlide = 5f;
    public float slideSpeed = 20f;
    public float direction = 1f;

    float startPos;
    void Awake()
    {
        startPos = transform.position.x;   
    }
    // Update is called once per frame
    void Update()
    {
        if (TurnRight())
            direction = 1f;
        if (TurnLeft())
            direction = -1f;

        Slide();
    }

    bool TurnRight()
    {
        return transform.position.x < startPos - radiusSlide;
    }
    bool TurnLeft()
    {
        return transform.position.x > startPos + radiusSlide;
    }

    void Slide()
    {
        transform.position += Vector3.right * direction * slideSpeed * Time.deltaTime;
    }
}
