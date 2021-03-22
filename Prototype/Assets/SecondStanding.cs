using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondStanding : MonoBehaviour
{
    public GameObject LerpController,Selim;

    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Selim"))
        {
            LerpController.GetComponent<SelimComes2>().enabled = false;
            Selim.GetComponent<Animator>().SetBool("isLerp", false);
            Selim.GetComponent<Animator>().SetBool("isSelimSitting", false);
            Selim.transform.rotation = Quaternion.Euler(x, y, z);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
