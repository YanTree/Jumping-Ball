using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMoveUp : MonoBehaviour
{
    public float upSpeed = 20f;

    bool toTop()
    {
        return transform.position.y >= 2;
    }

    void MoveUp()
    {
        transform.position += Vector3.up * upSpeed * Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        if (!toTop())
            MoveUp();
    }
}
