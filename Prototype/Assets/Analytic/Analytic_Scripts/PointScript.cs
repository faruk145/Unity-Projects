using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int point;
    private static int score;
    public GameObject AnalyticMission;

    bool flag = false;

    public GameObject Successful, Unsuccessful;

    public GameObject AycaControllerScript, SelimControllerScript;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cerceve") && flag == false)
        {
            score += point;
            flag = true;
        }
    }
    public void SetScore()
    {
        if (score >= 3)
        {
            Successful.SetActive(true);
            AycaControllerScript.GetComponent<AycaController>().enabled = true;
            SelimControllerScript.GetComponent<SelimComes>().enabled = true;
            AnalyticMission.SetActive(false);
        }
        else
        {
            Unsuccessful.SetActive(true);
            AycaControllerScript.GetComponent<AycaController>().enabled = true;
            AnalyticMission.SetActive(false);
        }
        Debug.Log(score);
    }

}
