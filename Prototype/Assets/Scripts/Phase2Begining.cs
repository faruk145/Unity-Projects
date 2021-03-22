using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2Begining : MonoBehaviour
{
    [SerializeField]
    GameObject[] us;
    public GameObject coffe_place;
    public GameObject  Mehmet, trigger_area, selim;


    Vector3 sitting_position = new Vector3(59f, 1f, 65.812f);
    public GameObject Trigger_Phase2_Unwalkable;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            us[0].GetComponent<Diyaloglar>().enabled = false;
            us[1].GetComponent<SceneManager>().enabled = false;
            Mehmet.GetComponent<Lerp>().enabled = false;
            Mehmet.GetComponent<Phase2_Lerp_Mehmet>().enabled = true;
            coffe_place.GetComponent<Coffee_Machine_Destination>().enabled = true;
            selim.GetComponent<Selim_Destination>().enabled = true;
            Mehmet.GetComponent<Lerp3>().enabled = false;
            Debug.Log("GirdikEnter");

        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            Mehmet.GetComponent<Lerp>().enabled = false;
            
            us[2].transform.position = sitting_position;
            Debug.Log("GirdikStay");
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            trigger_area.SetActive(false);
            Mehmet.GetComponent<Lerp>().enabled = false;
        }
    }
    public void TriggerDisappear()
    {
        Trigger_Phase2_Unwalkable.SetActive(false);
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
