using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DragAndDrop : MonoBehaviour
{

    public GameObject thing,background;
    Vector3 amount = new Vector3(0f, 0f, 0.1f);
    public void PositionChanger()
    {
            thing.transform.position = background.GetComponent<XRSimpleInteractable>().customReticle.transform.position;
    }
    public void MakeChild()
    {
        thing.transform.parent = thing.GetComponent<XRSimpleInteractable>().customReticle.transform; 
    }
    public void Revert()
    {
        thing.transform.parent = null;
    }
     void Start()
    {
        
    }
     void Update()
    {
        
    }
}
