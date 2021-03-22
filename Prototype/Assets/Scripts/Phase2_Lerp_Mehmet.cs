using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2_Lerp_Mehmet : MonoBehaviour
{
    [SerializeField] [Range(0f, 4f)] float lerpTime;
    [SerializeField] Vector3[] myPositions;
    int posIndex = 0;

    int lenght = 0;
    float t = 0f;

    [SerializeField] [Range(0f, 5f)] float lerpTime1;
    [SerializeField] Vector3[] myAngles;

    int angleIndex;
    int len;
    float trot = 0f;
    void DelayPos1()
    {
        myPositions[0] = myPositions[1];
    }
    void DelayRot1()
    {
        myAngles[0] = myAngles[1];
    }
    void DelayPos2()
    {
        myPositions[0] = myPositions[2];
        myPositions[1] = myPositions[2];
    }
    void DelayRot2()
    {
        myAngles[0] = myAngles[2];
        myAngles[1] = myAngles[2];
    }
    void Pos1()
    {
        transform.position = Vector3.Lerp(transform.position, myPositions[0], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
    }
    void Rot1()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(myAngles[0]), lerpTime1 * Time.deltaTime);
        trot = Mathf.Lerp(trot, 1f, lerpTime1 * Time.deltaTime);
    }
    void Pos2()
    {
        transform.position = Vector3.Lerp(transform.position, myPositions[1], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
    }
    void Rot2()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(myAngles[1]), lerpTime1 * Time.deltaTime);
        trot = Mathf.Lerp(trot, 1f, lerpTime1 * Time.deltaTime);
    }

    void Pos3()
    {
        transform.position = Vector3.Lerp(transform.position, myPositions[2], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
    }
    void Rot3()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(myAngles[2]), lerpTime1 * Time.deltaTime);
        trot = Mathf.Lerp(trot, 1f, lerpTime1 * Time.deltaTime);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Pos1", 0f);
        Invoke("Rot1", 0f);

        Invoke("DelayPos1", 6f);
        Invoke("DelayRot1", 6f);

        Invoke("Pos2", 7f);
        Invoke("Rot2", 7f);
        

        //Invoke("DelayPos2", 18f);
        //Invoke("DelayRot2", 18f);

        //Invoke("Pos3", 22f);
        //Invoke("Rot3", 22f);

    }


}
