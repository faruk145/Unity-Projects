using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mehmet : MonoBehaviour
{
    public static bool trigger1 = false;
    public static bool inRange = false;//Oyuncu Npc alanına girince aktif olacak
    public static bool inChat = false;//chat penceresi içi ve disinda aktifliği değişiyo
    public bool inDialogue1 = true;
    public bool inDialogueLeftSubTree = false;
    public bool inDialogueUpSubTree = false;
    [Header("Objects")]
    public GameObject npcWindow;
    public Text chatText;
    public Text leftText;
    public Text upText;
    public Text rightText;
    [Header("All Possible Dialogue Options")]
    public string greeting;
    [Header("Dialogue 1")]
    public string left1;
    public string leftResponse1;
    public string up1;
    public string upResponse1;
    public string right1;
    public string rightResponse1;
    [Header("Dialogue 1 LEFT Sub Tree")]
    public string left2;
    public string leftResponse2;
    public string up2;
    public string upResponse2;
    public string right2;
    public string rightResponse2;
    [Header("Dialogue 1 UP Sub Tree")]
    public string left3;
    public string leftResponse3;
    public string up3;
    public string upResponse3;
    public string right3;
    public string rightResponse3;



    void Start()
    {
        enabled = true;

    }


    
    void Update()
    {
       // trigger1 = Trigger.trigger;
        /*if (trigger1)
        {

            npcWindow.gameObject.SetActive(true);
            chatText.GetComponent<Text>().text = greeting;          
            loadDialogue1();
            enabled = false;
        }*/
    }

    //ilk mesaj seti
    void loadDialogue1()
    {
        inChat = true;
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        upText.GetComponent<Text>().text = up1;
        rightText.GetComponent<Text>().text = right1;
    }
    //sol buton ilk set mesajları
    void loadDialogueLeftSubTree()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = left2;
        upText.GetComponent<Text>().text = up2;
        rightText.GetComponent<Text>().text = right2;
    }
    //sol buton ikinci mesaj seti
    void loadDialogueLeftSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = "";
        upText.GetComponent<Text>().text = "";
    }
    //Yukarı buton ikinci mesaj seti
    void loadDialogueUpSubTree()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = true;
        leftText.GetComponent<Text>().text = left3;
        upText.GetComponent<Text>().text = up3;
        rightText.GetComponent<Text>().text = right3;
    }
    //yukarı buton ikinci mesaj seti
    void loadDialogueUpSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueUpSubTree = false;
        leftText.GetComponent<Text>().text = "";
        upText.GetComponent<Text>().text = "";
    }
    //BUTONLAR
    //Eğer oyuncu herhangi bir zamanda sol butona basarsa
    public void Left()
    {

        if (inDialogue1)
        {

            chatText.GetComponent<Text>().text = leftResponse1;            
            loadDialogueLeftSubTree();

        }
        else if (inDialogueLeftSubTree)
        {
            chatText.GetComponent<Text>().text = leftResponse2;
            loadDialogueLeftSubTree2();

        }
        else if (inDialogueUpSubTree)
        {
            chatText.GetComponent<Text>().text = leftResponse3;
            loadDialogueUpSubTree2();

        }

    }
    //Eğer oyuncu herhangi bir zamanda yukarı butona basarsa
    public void Up()
    {
        if (inDialogue1)
        {
            chatText.GetComponent<Text>().text = upResponse1;
            loadDialogueUpSubTree();
        }
        else if (inDialogueLeftSubTree)
        {
            chatText.GetComponent<Text>().text = upResponse2;
            loadDialogueLeftSubTree2();
        }
        else if (inDialogueUpSubTree)
        {
            chatText.GetComponent<Text>().text = upResponse3;
            loadDialogueUpSubTree2();
        }
    }
    public void Right()
    {
        CloseDialogue();
    }
    void CloseDialogue()
    {
        npcWindow.gameObject.SetActive(false);
        inChat = false;
    }
}


