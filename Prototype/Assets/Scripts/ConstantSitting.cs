using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSitting : MonoBehaviour
{
    public GameObject Phase3UnsuccessfullUnwalkable;
    Vector3 sitting_position = new Vector3(58.2f, 0.6f, 61.854f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Phase3UnsuccessfullUnwalkable.transform.position = sitting_position;
    }
}
