using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance_Keeping : MonoBehaviour
{
    public Animator genc;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Genc"))
        {
            genc.SetBool("isGencWalking", false);
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
