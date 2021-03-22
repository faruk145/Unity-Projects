using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoneticiExterior : MonoBehaviour
{
    [SerializeField]
    GameObject door_exterior;
    Animator exterior;

    private void OnTriggerEnter(Collider other)
    {

        exterior.SetBool("isYoneticiOpening", true);

    }
    private void OnTriggerExit(Collider other)
    {

        exterior.SetBool("isYoneticiOpening", false);

    }


    // Start is called before the first frame update
    void Start()
    {
        exterior = door_exterior.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
