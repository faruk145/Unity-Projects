using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour
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

        if (tempPos1.z > 60f)
        {
            transform.Rotate(0, speed, 0);
        }
        


    }
}
