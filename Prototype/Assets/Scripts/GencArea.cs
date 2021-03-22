using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GencArea : MonoBehaviour
{
    public Animator genc;
    public GameObject genco, area;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Genc"))
        {
            genc.SetBool("isGencWalking", false);
            genco.GetComponent<Hallway_Lerp>().enabled = false;
            area.SetActive(false);
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
