﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DisableBro()
    {
        this.GetComponent<Device>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
