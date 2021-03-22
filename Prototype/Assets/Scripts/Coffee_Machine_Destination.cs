using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee_Machine_Destination : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Mehmet_walk;
    public GameObject thecup,mehmet,selim;
    public GameObject trigger;
    public Vector3 a = new Vector3(57.051f, 1.6288f, 69.4885f);
    public Vector3 b;
    bool cup = false;
    public void MakeHimWalk()
    {
        Mehmet_walk.SetBool("isMehmetWalking", true);
    }
    public void DontMakeHimWalk()
    {
        Mehmet_walk.SetBool("isMehmetWalking", false);
    }
    public void MakeHimGrab()
    {
        Mehmet_walk.SetBool("isGrabbing", true);
    }
    public void DontMakeHimGrab()
    {
        Mehmet_walk.SetBool("isGrabbing", false);
    }
    public void Disable()
    {
        mehmet.GetComponent<Phase2_Lerp_Mehmet>().enabled = false;
    }
 
    public void MoveCup()
    {
        
       thecup.transform.position = Vector3.Lerp(thecup.transform.position, a, Time.deltaTime);
           
        
    }
    /*public void Couple()
    {
        thecup.transform.parent = GameObject.Find("CC_Base_R_Handm").transform;
    }*/
    public void SelimLerp()
    {
        selim.GetComponent<Phase2_Lerp_Selim>().enabled = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mehmet"))
        {
            DontMakeHimWalk();
            MakeHimGrab();
            Invoke("DestroyTrigger", 10f);
            Invoke("Disable", 5f);
            Invoke("SelimLerp", 9f);
            

        }
    }
    public void Teleport()
    {
        
          thecup.transform.position = GameObject.Find("CC_Base_R_Handm").transform.position + b;
          
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Mehmet"))
        {
            MoveCup();
            Invoke("Teleport", 5f);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //Couple();
        DestroyTrigger();
    }
    public void DestroyTrigger()
    {
        trigger.SetActive(false);
    }
    void Start()
    {
        MakeHimWalk();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
