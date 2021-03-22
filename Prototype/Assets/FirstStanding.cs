using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStanding : MonoBehaviour
{
    public GameObject LerpController;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Selim"))
        {
            LerpController.GetComponent<SelimComes2>().enabled = true;
            LerpController.GetComponent<SelimComes>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
