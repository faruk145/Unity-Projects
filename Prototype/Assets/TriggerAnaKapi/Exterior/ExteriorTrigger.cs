using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExteriorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject sol, sag;
    Animator exteriorsol, exteriorsag;

     public GameObject d;

     void Disable()
    {
        d.SetActive(false);
    }
     void Enable()
    {
        d.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        exteriorsag.SetBool("isSagOpening", true);
        exteriorsol.SetBool("isSolOpening", true);
        Invoke("Disable", 0f);
    }
    
    private void OnTriggerExit(Collider other)
    {
        exteriorsag.SetBool("isSagOpening", false);
        exteriorsol.SetBool("isSolOpening", false);
        Invoke("Enable", 3f);
    }


    // Start is called before the first frame update
    void Start()
    {
        exteriorsol = sol.transform.GetComponent<Animator>();
        exteriorsag = sag.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
