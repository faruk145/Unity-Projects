using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

public class SitDown : MonoBehaviour
{
    public GameObject Main_camera, canvas, button, desk_area;
    Vector3 sitting_position = new Vector3(58.037f, 1.83f, 61.854f);
    public GameObject mehmet_script;


    public GameObject empty;
   
    
    


    public void EnableScript()
    {
        mehmet_script.GetComponent<Phase3_Mehmet_Lerp>().enabled = true;
    }
    
    public void Disappear()
    {
        button.SetActive(false);
        canvas.SetActive(false);
        desk_area.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            canvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            canvas.SetActive(false);
        }
    }
    public void Sit()
    {
        
        Main_camera.transform.position = sitting_position;
        Main_camera.transform.rotation = Quaternion.Euler(0, -90, 0);
        
        
        
        
        empty.GetComponent<ConstantSitting>().enabled = true;
        
    }
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
}
