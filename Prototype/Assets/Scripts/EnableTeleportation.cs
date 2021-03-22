using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTeleportation : MonoBehaviour
{
    public GameObject selim,pos, mehmet, posm;

    public void Enable_Teleportation()
    {
        this.GetComponent<Teleportation_To_Conference>().enabled = true;
        selim.GetComponent<Phase2_Lerp_Selim>().enabled = false;
        pos.GetComponent<Selim_Destination>().enabled = false;
        mehmet.GetComponent<Phase2_Lerp_Mehmet>().enabled = false;
        posm.GetComponent<Coffee_Machine_Destination>().enabled = false;
    }
    public void EnableDelayed()
    {
        Invoke("Enable_Teleportation", 1f);
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
