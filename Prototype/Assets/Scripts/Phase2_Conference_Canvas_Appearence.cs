using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2_Conference_Canvas_Appearence : MonoBehaviour
{
    public GameObject phase2_canvas;
    public void Appear()
    {
        phase2_canvas.SetActive(true);
    }
    public void Disappear()
    {
        phase2_canvas.SetActive(false);
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
