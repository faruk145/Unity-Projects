using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject text;
    public GameObject canvas;
    public void Disappear()
    {
        canvas.SetActive(false);
    }
    public void SetScore()
    {
        text.SetActive(true);
        Invoke("Disappear", 3f);
        

    }
}
 