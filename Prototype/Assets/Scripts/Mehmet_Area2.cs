using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mehmet_Area2 : MonoBehaviour
{
    public GameObject mehmet;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mehmet"))
        {
            mehmet.GetComponent<Lerp>().enabled = false;
            mehmet.GetComponent<Lerp2>().enabled = false;
            mehmet.GetComponent<Lerp3>().enabled = true;

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
