using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3_Mehmet_Dialogue_Appearence : MonoBehaviour
{
    public GameObject canvas, mission_canvas;
    public void Appear()
    {
        canvas.SetActive(true);
    }
    public void Disappear()
    {
        canvas.SetActive(false);
    }
    public void AppearMission()
    {
        mission_canvas.SetActive(true);
    }
    public void DisappearMission()
    {
        mission_canvas.SetActive(false);
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
