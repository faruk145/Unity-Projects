using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Phase4_Young_Person_Comes : MonoBehaviour
{
    public GameObject cube;
    public void MoveTowards()
    {
        cube.GetComponent<Phase4_Young_Person_Move_Towards>().enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
