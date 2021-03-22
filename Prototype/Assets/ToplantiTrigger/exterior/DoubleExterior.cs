using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleExterior : MonoBehaviour
{
    [SerializeField]
    GameObject sol_exterior, sag_exterior;
    Animator exsol, exsag;

    public GameObject double_in;
    void Disable()
    {
        double_in.SetActive(false);
    }
    void Enable()
    {
        double_in.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {

        exsol.SetBool("isOpeningSol", true);
        exsag.SetBool("isOpeningSag", true);
        Invoke("Disable", 0f);

    }
    private void OnTriggerExit(Collider other)
    {

        exsol.SetBool("isOpeningSol", false);
        exsag.SetBool("isOpeningSag", false);
        Invoke("Enable", 3f);
    }

    // Start is called before the first frame update
    void Start()
    {
        exsol = sol_exterior.transform.GetComponent<Animator>();
        exsag = sag_exterior.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
