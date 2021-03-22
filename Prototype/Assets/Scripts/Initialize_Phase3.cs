using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize_Phase3 : MonoBehaviour
{
    public GameObject mehmet, mehmet_Dialogue_Canvas;
    public Animator memo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mehmet"))
        {
            mehmet_Dialogue_Canvas.SetActive(true);
            memo.SetBool("isMehmetWalking", false);
        }
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
