﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    [SerializeField] float startTimeBtwSpawns;
    float timeBtwSpawns;

    [SerializeField] GameObject echo;



    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawns <= 0)
        {
            Instantiate(echo, transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns = Time.deltaTime;
        }
    }
}
