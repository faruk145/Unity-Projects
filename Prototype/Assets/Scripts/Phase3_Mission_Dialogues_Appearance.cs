using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3_Mission_Dialogues_Appearance : MonoBehaviour
{
    public GameObject canvas;

    public void Appear()
    {
        canvas.SetActive(true);
    }
    public void Disappear()
    {
        canvas.SetActive(false);
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
