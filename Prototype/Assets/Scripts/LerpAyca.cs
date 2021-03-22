using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpAyca : MonoBehaviour
{
    public GameObject Ayca;
    public Vector3 target;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        Ayca.transform.rotation = Quaternion.Euler(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        Ayca.transform.position = Vector3.MoveTowards(Ayca.transform.position, target, Time.deltaTime);
    }
}
