using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject sol, sag;
    Animator interiorsol, interiorsag;

    public GameObject s;
    void Disable()
    {
        s.SetActive(false);
    }
    void Enable()
    {
        s.SetActive(true);
    }

    public void OnTriggerEnter(Collider other)
    {
        interiorsag.SetBool("isSagDiger", true);
        interiorsol.SetBool("isSolDiger", true);
        Invoke("Disable", 0f);
    }
    
    public void OnTriggerExit(Collider other)
    {
        interiorsag.SetBool("isSagDiger", false);
        interiorsol.SetBool("isSolDiger", false);
        Invoke("Enable", 3f);
    }

    // Start is called before the first frame update
    void Start()
    {
        interiorsol = sol.transform.GetComponent<Animator>();
        interiorsag = sag.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
