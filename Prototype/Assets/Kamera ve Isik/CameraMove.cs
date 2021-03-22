using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    
    Vector3 tempPos1;
    private bool phase1 = false;
    public float speed;

    void Start()
    {
        tempPos1 = transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {

        if (tempPos1.x < 53.08f)
        {
            tempPos1.x += speed;
            transform.position = tempPos1;
        }
        if (tempPos1.x >= 53.08f && transform.rotation != Quaternion.Euler(0,180,0))
        {
            phase1 = true;
            transform.Rotate(0, 10f, 0);
            
        }
        if (phase1 == true && tempPos1.z > 66f )
        {
            tempPos1.z -= speed;
            transform.position = tempPos1;
        }
        
        
    }
}
