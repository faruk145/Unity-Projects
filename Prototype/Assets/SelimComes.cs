using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelimComes : MonoBehaviour
{
    public GameObject Selim;
    public Vector3 target;
    public float x, y, z, speed;
    // Start is called before the first frame update
    void Start()
    {
        Selim.GetComponent<Animator>().SetBool("isLerp", true);
        Selim.transform.rotation = Quaternion.Euler(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        Selim.transform.position = Vector3.MoveTowards(Selim.transform.position, target, Time.deltaTime * speed);
    }
}
