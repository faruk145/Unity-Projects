using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation_To_Conference : MonoBehaviour
{
    public Animator s, m;
    [SerializeField]
    GameObject deniz, selim, mehmet, ayca, cup;
    public Vector3[] a;
    // Start is called before the first frame update

    public void MakeSelimSit()
    {
        s.SetBool("isSelimSitting", true);
    }
    public void MakeMehmetSit()
    {
        m.SetBool("isMehmetSitting", true);
    }
    


    public void TeleportDeniz()
    {
        deniz.transform.position = a[0];
        deniz.transform.rotation = Quaternion.Euler(0, 90, 0);
        
    }
    public void TeleportMehmet()
    {
        mehmet.transform.position = a[1];
        mehmet.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    public void TeleportSelim()
    {
        selim.transform.position = a[2];
        selim.transform.rotation = Quaternion.Euler(0, 0, 0);

    }
    public void TeleportAyca()
    {
        ayca.transform.position = a[3];
        ayca.transform.rotation = Quaternion.Euler(0, -90, 0);
    }
    public void TeleportCup()
    {
        cup.transform.position = a[4];
    }
    
    public void DelayedTeleport()
    {
        Invoke("TeleportDeniz", 5f);
    }
    
    void Start()
    {
        TeleportDeniz();
        TeleportAyca();
        TeleportMehmet();
        TeleportSelim();
        TeleportCup();

        MakeMehmetSit();
        MakeSelimSit();

        
    }

    // Update is called once per frame
    void Update()
    {
        selim.GetComponent<Phase2_Lerp_Selim>().enabled = false;
        mehmet.GetComponent<Phase2_Lerp_Mehmet>().enabled = false;
        //DelayedTeleport();
    }
}
