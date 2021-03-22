using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleInterior : MonoBehaviour
{
    [SerializeField]
    GameObject sol, sag;
    Animator interiorsol, interiorsag;

    public GameObject double_ex;
    public void Disable()
    {
        double_ex.SetActive(false);
    }
    public void Enable()
    {
        double_ex.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {

        interiorsol.SetBool("isSolDigertaraf", true);
        interiorsag.SetBool("isSagDigerTaraf", true);
        Invoke("Disable", 0f);

    }
    private void OnTriggerExit(Collider other)
    {

        interiorsol.SetBool("isSolDigertaraf", false);
        interiorsag.SetBool("isSagDigerTaraf", false);
        Invoke("Enable", 0f);

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
