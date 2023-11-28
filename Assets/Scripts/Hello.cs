using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    string name = "Hong";

    // Start is called before the first frame update
    void Start()
    {
        int age;
        age = 1;

        Run();

        Debug.Log("START");
    }

    void Run() 
    {
        
        // 동작
        Debug.Log("RUN");
    }
}
