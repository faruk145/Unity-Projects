using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerController : MonoBehaviour
{
    [SerializeField]
    GameObject interior, exterior, left_door, right_door, us, mehmet3;

    bool inside = false;
    bool outside = true;

    Animator leftcam, rightcam;

    public Animator memocan;
    void DontWalkMehmet()
    {
        memocan.SetBool("isMehmetWalking", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        leftcam = left_door.transform.GetComponent<Animator>();
        rightcam = right_door.transform.GetComponent<Animator>();
        interior.SetActive(false);
        exterior.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (us.transform.position.x < 58.0f && mehmet3.transform.position.x > 56.0f && inside == false)
        {
            leftcam.SetBool("isSolOpening", true);
            rightcam.SetBool("isSagOpening",true);
            inside = true;
            Invoke("DontWalkMehmet", 3f);
            
        }
        else if (us.transform.position.x > 58.0f && mehmet3.transform.position.x > 56.0f && outside == true )
        {
            leftcam.SetBool("isSolOpening", false);
            rightcam.SetBool("isSagOpening", false);
            Debug.Log("Girdi");
            outside = false;
            interior.SetActive(true);
            exterior.SetActive(true);
        }
    }
}
