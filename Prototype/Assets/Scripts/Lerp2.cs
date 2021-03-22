using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp2 : MonoBehaviour
{
    public Vector3 target;
    public float x, y, z;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target, speed);
    }
}
