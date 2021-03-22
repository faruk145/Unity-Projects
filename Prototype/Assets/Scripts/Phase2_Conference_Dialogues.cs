using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RogoDigital.Lipsync;

public class Phase2_Conference_Dialogues : MonoBehaviour
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


    public GameObject Cam;
    public Vector3 StandingPosition = new Vector3(65.693f, 1.724f, 67.242f);

    public GameObject canvas; //Yoktu
    void Start()
    {

        loadDialogue1();

    }

    void Update()
    {
        Cam.transform.position = StandingPosition;
    }


    public LipSync s1,s2,s3,m1,m2,ayca;
    public LipSyncData SD1, SD2, SD3, MD1, MD2, AycaD;

    public LipSync s4,s5,s6,s7,s8,s9;
    public LipSyncData SD4,SD5,SD6,SD7,SD8,SD9;

    


    //ilk mesaj seti
    public void loadDialogue1()
    {
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        rightText.GetComponent<Text>().text = right1;
        s1.Play(SD1, 1f);
        m1.Play(MD1, 17f);
        s2.Play(SD2, 38f);
        ayca.Play(AycaD, 46f);
        m2.Play(MD2, 64f);
        s3.Play(SD3, 75f);
    }
    //sol buton ilk set mesajları
    public void loadDialogueLeftSubTree()
    {
        //LeftResponse();
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left2_Left;
        rightText.GetComponent<Text>().text = right2_Left;
        s4.Play(SD4, 1f);



    }
    //sol buton ikinci mesaj seti
    public void loadDialogueLeftSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false; 
        inDialogueRightSubTree = false;
        canvas.SetActive(false);
        s5.Play(SD5, 1f);
        Debug.Log("Ben S5");

    }
    //Sağ buton ilk mesaj seti
    public void loadDialogueRightSubTree()
    {
        //RightResponse();
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = true;
        leftText.GetComponent<Text>().text = left4;
        rightText.GetComponent<Text>().text = right4;
        s7.Play(SD7, 1f);
        Debug.Log("Ben S7");

    }
    //Sağ buton ikinci mesaj seti
    public void loadDialogueRightSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        //leftText.GetComponent<Text>().text = "";
        //upText.GetComponent<Text>().text = "";
        s8.Play(SD8, 1f);
        Debug.Log("Ben S8 ");
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
        else if (inDialogueLeftSubTree)
        {
            //MehmetIsKitlemek_Left();
            loadDialogueLeftSubTree2();

        }
        else if (inDialogueRightSubTree)
        {
            loadDialogueRightSubTree2();
            //MehmetResponseLeft();
            canvas.SetActive(false);//yoktu
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
            s6.Play(SD6, 1f);
            Debug.Log("Ben S6");
        }
        else if (inDialogueRightSubTree)
        {
            s9.Play(SD9, 1f);
            Debug.Log("Ben S9");
            canvas.SetActive(false);
        }
    }
    public Animator Selim, Mehmet, Ayca;
    public void SelimRightTurn()
    {
        Selim.SetBool("isSagSitting", true);
    }
    public void SelimRightTurnBack()
    {
        Selim.SetBool("isSagSitting", false);
    }
    public void SelimLeftTurn()
    {
        Selim.SetBool("isSolSitting", true);
    }
    public void SelimLeftTurnBack()
    {
        Selim.SetBool("isSolSitting", false);
    }

    public void MehmetRightTurn()
    {
        Mehmet.SetBool("isSagSitting", true);
    }
    public void MehmetRightTurnBack()
    {
        Mehmet.SetBool("isSagSitting", false);
    }
    public void MehmetLeftTurn()
    {
       Mehmet.SetBool("isSolSitting", true);
    }
    public void MehmetLeftTurnBack()
    {
        Mehmet.SetBool("isSolSitting", false);
    }

    public void AycaRightTurn()
    {
        Ayca.SetBool("isSagSitting", true);
    }
    public void AycaRightTurnBack()
    {
        Ayca.SetBool("isSagSitting", false);
    }
    public void AycaLeftTurn()
    {
        Ayca.SetBool("isSolSitting", true);
    }
    public void AycaLeftTurnBack()
    {
        Ayca.SetBool("isSolSitting", false);
    }

    public void AycaChangeSitting()
    {
        Ayca.SetBool("isChangeSitting", true);
    }
    public void AycaChangeSittingAgain()
    {
        Ayca.SetBool("isChangeSitting", false);
    }
}
