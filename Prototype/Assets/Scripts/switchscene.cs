using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switchscene : MonoBehaviour
{
    public Animator PanelAnim;
    // Start is called before the first frame update
    public GameObject canvas;
    public GameObject otherCanvas;
    public GameObject Phase2_dialogues;


    public void Fade()
    {
        PanelAnim.SetBool("isFading", true);
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
        Phase2_dialogues.GetComponent<Phase2_Conference_Dialogues>().enabled = true;
        //a.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
