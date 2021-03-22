using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AycaStandingPoint : MonoBehaviour
{
    public GameObject AycaComes;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ayca"))
        {
            AycaComes.GetComponent<AycaController>().enabled = false;
            AycaComes.GetComponent<LerpAyca>().enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
