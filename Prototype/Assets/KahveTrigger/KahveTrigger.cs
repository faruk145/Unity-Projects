using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KahveTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject akan, akmayan1, akmayan2;
    Animator akan_kahve, akmayan_kahve1, akmayan_kahve2;

    private void OnTriggerEnter(Collider other)
    {
        akan_kahve.SetBool("isFlowing", true);
        if (other.gameObject.tag == "Bardak1")
            akmayan_kahve1.SetBool("isFilling", true);
        else
            akmayan_kahve2.SetBool("isFilling", true);
    }
    private void OnTriggerExit(Collider other)
    {
        akan_kahve.SetBool("isFlowing", false);
        if (other.gameObject.tag == "Bardak1")
            akmayan_kahve1.SetBool("isFilling", false);
        else
            akmayan_kahve2.SetBool("isFilling", false);
    }


    // Start is called before the first frame update
    void Start()
    {
        akan_kahve = akan.transform.GetComponent<Animator>();
        akmayan_kahve1 = akmayan1.transform.GetComponent<Animator>();
        akmayan_kahve2 = akmayan2.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
