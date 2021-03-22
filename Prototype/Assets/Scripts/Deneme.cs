using RogoDigital.Lipsync;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    public LipSync a1, a2, a3;
    public LipSyncData AD1, AD2, AD3;

    // Start is called before the first frame update
    void Start()
    {
        a1.Play(AD1, 0f);
        a2.Play(AD2, 4f);
        a3.Play(AD3, 7f);
        Debug.Log("Hit it");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
