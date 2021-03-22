using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AycaController : MonoBehaviour
{
    public Animator Ayca;
    public GameObject ayca;

    public Vector3 target1;

    public float rotx1, roty1, rotz1;
    // Start is called before the first frame update
    void Start()
    {
        Ayca.SetBool("isWalking", true);
        ayca.transform.rotation = Quaternion.Euler(rotx1, roty1, rotz1);
    }

    // Update is called once per frame
    void Update()
    {
        ayca.transform.position = Vector3.MoveTowards(ayca.transform.position, target1, Time.deltaTime);
    }
}
