using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AycasFinalDestination : MonoBehaviour
{
    public GameObject Ayca;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ayca"))
        {
            Ayca.GetComponent<Animator>().SetBool("isWalking", false);
            Ayca.transform.rotation = Quaternion.Euler(x, y, z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
