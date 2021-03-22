using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway_Lerp : MonoBehaviour
{
    public Vector3 target;
    public Animator genc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target, Time.deltaTime);
        genc.SetBool("isGencWalking", true);
    }
}
