using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2 : MonoBehaviour
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

        if (tempPos1.z > 60f && transform.rotation != Quaternion.Euler(37,-38,0))
        {
            transform.Rotate(speed, 0, 0);
        }



    }
}
