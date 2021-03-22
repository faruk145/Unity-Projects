using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3_Beginning : MonoBehaviour
{
    public GameObject MehmetStuff, SelimStuff, canvasStuff, coffeDestination, selimDestination;
    public GameObject phase3_canvas;
    public void EndPhase2()
    {
        MehmetStuff.GetComponent<Phase2_Lerp_Mehmet>().enabled = false;
        SelimStuff.GetComponent<Phase2_Lerp_Selim>().enabled = false;
        selimDestination.GetComponent<Selim_Destination>().enabled = false;
        coffeDestination.GetComponent<Coffee_Machine_Destination>().enabled = false;
        canvasStuff.SetActive(false);
        phase3_canvas.SetActive(true);
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
