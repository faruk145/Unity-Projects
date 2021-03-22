using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase3_Switchscene : MonoBehaviour
{
    public Animator PanelAnim;
    public GameObject canvas,phase2_dialogues;
    public GameObject DeskArea;
    public void Desk_Area()
    {
        DeskArea.SetActive(true);
    }
    public void Fade()
    {
        PanelAnim.SetBool("isPhase3Fading", true);
    }
    public void Unfade()
    {
        PanelAnim.SetBool("isFading", false);
    }
    public void DisappearCanvas()
    {
        canvas.SetActive(false);
    }
    public void UnfadeDelayed()
    {
        Invoke("Unfade", 1.5f);
        phase2_dialogues.GetComponent<Phase2_Conference_Dialogues>().enabled = false;
       
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
