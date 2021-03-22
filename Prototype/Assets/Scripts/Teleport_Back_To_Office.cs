using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Back_To_Office : MonoBehaviour
{
    public GameObject Mehmet, Selim, Ayca, Deniz;
    public Vector3[] a;
    public Animator m;
    public GameObject desk_area;
    public void TeleportDeniz()
    {
        Deniz.transform.position = a[0];
        Deniz.transform.rotation = Quaternion.Euler(0, -90, 0);
    }
    public void TeleportMehmet()
    {
        Mehmet.transform.position = a[1];
        Mehmet.transform.rotation = Quaternion.Euler(0, -180, 0);
        m.SetBool("isMehmetSitting", false);
        m.SetBool("isGrabbing", false);
    }
    public void TeleportSelim()
    {
        Selim.transform.position = a[2];
        Selim.transform.rotation = Quaternion.Euler(0, -98, 0);

    }
    public void TeleportAyca()
    {
        Ayca.transform.position = a[3];
        Ayca.transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    public void CollectiveTeleport()
    {
        TeleportAyca();
        TeleportDeniz();
        TeleportMehmet();
        TeleportSelim();
        
    }
    public void DelayedTeleport()
    {
        Invoke("CollectiveTeleport", 1f);
        desk_area.SetActive(true);

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
