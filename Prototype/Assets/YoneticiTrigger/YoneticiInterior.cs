using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoneticiInterior : MonoBehaviour
{
    [SerializeField]
    GameObject door_interior;
    Animator interior;

    private void OnTriggerEnter(Collider other)
    {

        interior.SetBool("isOpeningDigerTaraf", true);

    }
    private void OnTriggerExit(Collider other)
    {

        interior.SetBool("isOpeningDigerTaraf", false);

    }



    // Start is called before the first frame update
    void Start()
    {
        interior = door_interior.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
