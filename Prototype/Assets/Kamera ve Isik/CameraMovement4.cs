using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement4 : MonoBehaviour
{
    Vector3 tempPos1;
    public float speed;

    void Start()
    {
        tempPos1 = transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        if (tempPos1.x < 70f)
        {
            tempPos1.x -= speed;
            transform.position = tempPos1;
        }
        


    }
}
