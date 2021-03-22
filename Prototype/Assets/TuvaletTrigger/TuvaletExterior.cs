using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuvaletExterior : MonoBehaviour
{
    [SerializeField]
    GameObject tuvalet_exterior;
    Animator exterior;
    private void OnTriggerEnter(Collider other)
    {

        exterior.SetBool("isOpeningTuvalet", true);

    }
    private void OnTriggerExit(Collider other)
    {

        exterior.SetBool("isOpeningTuvalet", false);

    }


    // Start is called before the first frame update
    void Start()
    {
        exterior = tuvalet_exterior.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
