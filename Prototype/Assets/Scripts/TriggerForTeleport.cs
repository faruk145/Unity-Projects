using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForTeleport : MonoBehaviour
{
    public GameObject deniz;
    public Vector3 a;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            deniz.transform.position = a;
            deniz.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
