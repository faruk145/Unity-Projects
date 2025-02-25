﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.5f;
    public float rotatingSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.RotateAround(transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);
          //transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, Vector3.up, -rotatingSpeed * Time.deltaTime);
            //transform.position += Vector3.left * speed * Time.deltaTime;//or transform.position -= Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;

        }
    }
}
