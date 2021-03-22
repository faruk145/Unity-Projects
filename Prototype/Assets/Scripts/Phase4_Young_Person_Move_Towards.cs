using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase4_Young_Person_Move_Towards : MonoBehaviour
{
    //Gence atilcak
    public Transform Deniz;
    public Animator Genc;
    public Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        Deniz = GameObject.Find("Main Camera").transform;
        Genc.SetBool("isGencWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Deniz.position + distance, Time.deltaTime);
    }
    
}
