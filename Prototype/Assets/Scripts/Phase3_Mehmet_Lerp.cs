using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3_Mehmet_Lerp : MonoBehaviour
{
    public GameObject mehmet;
    public Animator memo;
    public Vector3 target;
    public float speed, angle;
   
    // Start is called before the first frame update
    void Start()
    {
        memo.SetBool("isMehmetWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
          mehmet.transform.position = Vector3.MoveTowards(mehmet.transform.position, target, speed);
          mehmet.transform.rotation = Quaternion.Euler(0, angle, 0);  
    }
}
