using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital;
using RogoDigital.Lipsync;

public class Selim_Destination : MonoBehaviour
{
    public LipSync duyuru;
    public LipSyncData arkadaslar_5dk;

    public GameObject canvas, trigger;

    public void SceneTransitionPanel()
    {
        canvas.SetActive(true);
    }
    public void SceneDelayed()
    {
        Invoke("SceneTransitionPanel", 1f);
    }

    public Animator selim;
    public GameObject selim1;
    bool iswalking = false;
    
    public void MakeHimWalk()
    {
        if (iswalking == false)
        {
            selim.SetBool("isWalkingSelim", true);
            iswalking = true;
            selim1.GetComponent<Phase2_Lerp_Selim>().enabled = true;
        }
    }
    public void DontMakeHimWalk()
    {
        selim.SetBool("isWalkingSelim", false);
    }
    public void CallScript()
    {
        selim1.GetComponent<Phase2_Lerp_Selim>().enabled = false;
    }
    /*public void EnableScript()
    {
        selim1.GetComponent<Phase2_Lerp_Selim>().enabled = true;
    }*/
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Selim"))
        {
            DontMakeHimWalk();
            duyuru.Play(arkadaslar_5dk, 2f);
            Invoke("CallScript", 1f);
            trigger.SetActive(false);
        }
    }
   
    void Start()
    {
        DontMakeHimWalk();
    }

    // Update is called once per frame
    void Update()
    {
        
        Invoke("MakeHimWalk", 12f);
    }
}
