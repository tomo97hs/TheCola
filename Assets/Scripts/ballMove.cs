﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{

    GameObject sphere;
    bool spheremove = true;
    //float i = 1;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (spheremove)
        {
            transform.position += new Vector3(0.0f, 0.0f, 3f * Time.deltaTime);

            if (transform.position.z >= 8)

                spheremove = false;
        }
        else
        {
            transform.position -= new Vector3(0.0f, 0.0f, 3f * Time.deltaTime);
            if (transform.position.z <= 4.5)
                spheremove = true;
        }
    }
}
