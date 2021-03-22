using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;
using UnityEngine.UI;

public class Phase3_Mission_Dialogues_Successful : MonoBehaviour
{
    public bool inDialogue1 = true;
    public bool inDialogueLeftSubTree = false;
    public bool inDialogueRightSubTree = false;
    [Header("Objects")]
    public GameObject npcWindow;
    public Text leftText;
    public Text upText;
    public Text rightText;
    [Header("All Possible Dialogue Options")]
    [Header("Dialogue 1")]
    public string left1;
    public string right1;
    [Header("Dialogue 1 LEFT Sub Tree")]
    public string left2_Left;
    public string right2_Left;
    public string rightResponse2;
    [Header("Dialogue 1 UP Sub Tree")]
    public string left3;
    public string leftResponse3;
    public string right3;
    public string rightResponse3;
    public string left4;
    public string right4;


    public GameObject Phase3UnsuccessfullUnwalkable;
    private Vector3 Phase3Standing = new Vector3(58.125f, 0.6f, 61.922f);


    public GameObject canvas; //Yoktu
    public GameObject EndCanvas;
    void Start()
    {
        Phase3UnsuccessfullUnwalkable.transform.rotation = Quaternion.Euler(0, 270, 0);
        loadDialogue1();

    }

    void Update()
    {
        Phase3UnsuccessfullUnwalkable.transform.position = Phase3Standing;
    }


    public LipSync s1, s2, s3, a1, a2, a3;
    public LipSyncData SD1, SD2, SD3, AD1, AD2, AD3;

    public GameObject deniz;
    

    public Vector3 pos;
    



    public void EndCanvasTrigger()
    {
        EndCanvas.SetActive(true);
    }


    //ilk mesaj seti
    public void loadDialogue1()
    {
        //Selim:Karakter eşleşme
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        rightText.GetComponent<Text>().text = right1;
        s1.Play(SD1, 12f);
        Debug.Log("Selim:Karakter eşleşme");
    }
    //sol buton ilk set mesajları
    public void loadDialogueLeftSubTree()
    {
        //Selim:Mükemmel
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        s3.Play(SD3, 0f);
        Debug.Log("Selim:Mükemmel");
        canvas.SetActive(false);
       

    }
    //sol buton ikinci mesaj seti
    public void loadDialogueLeftSubTree2()
    {
        //Ayca:Valla ben önce
        inDialogue1 = false;
        inDialogueLeftSubTree = false; 
        inDialogueRightSubTree = false;
        a3.Play(AD3, 0f);
        Debug.Log("Ayca:Valla ben önce");
        
        deniz.transform.position = pos;
        deniz.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        canvas.SetActive(false);
        
    }
    //Sağ buton ilk mesaj seti
    public void loadDialogueRightSubTree()
    {
        //Selim: he öyle mi
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = true;
        leftText.GetComponent<Text>().text = left4;
        rightText.GetComponent<Text>().text = right4;
        s2.Play(SD2, 0f);
        a1.Play(AD1, 7f);
        Debug.Log("Selim: he öyle mi,Ayca:Bu kadar kısa sürede");
        

    }
    //Sağ buton ikinci mesaj seti
    public void loadDialogueRightSubTree2()
    {
        //Ayca:Hmm ustalık
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        a2.Play(AD2, 0f);
        
        deniz.transform.position = pos;
        Debug.Log("Ayca:Hmm ustalık");
        deniz.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        canvas.SetActive(false);
        
    }
    //BUTONLAR
    //Eğer oyuncu herhangi bir zamanda sol butona basarsa
    public void Left()
    {
        if (inDialogue1)
        {
            loadDialogueLeftSubTree();
        }
       
        else if (inDialogueRightSubTree)
        {
            loadDialogueLeftSubTree2();
            inDialogueRightSubTree = false;
            
        }
    }
    //Eğer oyuncu herhangi bir zamanda sağ butona basarsa
    public void Right()
    {
        if (inDialogue1)
        {

            loadDialogueRightSubTree();
        }
        else if (inDialogueLeftSubTree)
        {
            
            //MehmetIsKitlemek_Right();
            //chatText.GetComponent<Text>().text = rightResponse2;
            //loadDialogueLeftSubTree2();
        }
        else if (inDialogueRightSubTree)
        {
            loadDialogueRightSubTree2();
            inDialogueRightSubTree = false;
        }
    }
    
  
}
