using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerForPoints : MonoBehaviour
{
    public GameObject go;
    /*void Update()
    {
        PointScript script;
        script = go.GetComponent<PointScript>();
        if (Input.GetMouseButtonUp(0))
        {
            script.enabled = true;
        }    
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Girdi");
        PointScript script;
        script = go.GetComponent<PointScript>();
        script.enabled = true;
        
    }
}