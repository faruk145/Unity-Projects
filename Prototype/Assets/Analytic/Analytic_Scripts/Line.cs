using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    LineRenderer cizgimiz;
    Transform kup_1;
    Transform kup_2;
    Transform kup_3;

     void Start()
    {
        cizgimiz = GetComponent<LineRenderer>();
        kup_1 = GameObject.Find("Circle").transform;
        kup_2 = GameObject.Find("Circle (1)").transform;
        kup_3 = GameObject.Find("Circle (2)").transform;

        cizgimiz.SetPosition(0, kup_1.position);
        cizgimiz.SetPosition(1, kup_2.position);
        cizgimiz.SetPosition(2, kup_3.position);
    }

    private void Update()
    {
        
    }
}
