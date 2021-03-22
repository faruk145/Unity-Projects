using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RogoDigital.Lipsync;

public class Diyaloglar : MonoBehaviour
{
    public GameObject us;

    public LipSync m1, a1, m2;
    public LipSyncData mv1, av1, mv2;
    public GameObject options;

    public LipSync Mehmet_walking_right, Mehmet_Walking_Left;
    public LipSyncData walking_right, walking_left;

    bool right_bool, left_bool = false;
    public void RightCheck()
    {
        right_bool = true;
    }

    public void LeftCheck()
    {
        left_bool = true;
    }

    public void Talk_right()
    {
        Mehmet_walking_right.Play(walking_right, 1f);
    }
    public void Talk_left()
    {
        Mehmet_Walking_Left.Play(walking_left, 1f);
    }

    bool isDoorOpen;
    public Animator mehmet, asli;

    [SerializeField]
    GameObject sol, sag;
    Animator left, right;

   


    public GameObject memo;

    // Start is called before the first frame update
    void Start()
    {
        m1.Play(mv1, 4f);
        a1.Play(av1, 11f);
        m2.Play(mv2, 31f);
        left = sol.transform.GetComponent<Animator>();
        right = sag.transform.GetComponent<Animator>();
        
    }
    public void WalkMehmet()
    {
        mehmet.SetBool("isMehmetWalking", true);
        memo.GetComponent<Lerp>().enabled = true;
    }
    void DontWalkMehmet()
    {
        mehmet.SetBool("isMehmetWalking", false);
    }
    // Update is called once per frame
    void Update()
    {
        
        /*if (isDoorOpen == true)
        {
            Invoke("WalkMehmet", 2f);
        }*/
        /*if (us.transform.position.x > 52f)
        {
            CloseDoor();
        }*/
        if (us.transform.position.x > 52f && right_bool == true)
        {
            Talk_right();
            enabled = false;
        }
        if (us.transform.position.x > 52f && left_bool == true)
        {
            Talk_left();
            enabled = false;
        }

    }
    
    public void Appear()
    {
        options.SetActive(true);
    }

    public void DisAppear()
    {
        options.SetActive(false);
    }
   
 

    public void OpenDoor()
    {
        left.SetBool("isSolOpening", true);
        right.SetBool("isSagOpening", true);
        isDoorOpen = true;
    }
    public void CloseDoor()
    {
        left.SetBool("isSolOpening", false);
        right.SetBool("isSagOpening", false);
        isDoorOpen = false;
    }
    public void MehmetLeftHeadTurn()
    {
        mehmet.SetBool("isSol", true);
    }
    public void MehmetLeftTurnBack()
    {
        mehmet.SetBool("isSol", false);
    }

    public void AsliRightHeadTurn()
    {
        asli.SetBool("isSag", true);
    }
    public void AsliRightTurnBack()
    {
        asli.SetBool("isSag", false);
    }
}
