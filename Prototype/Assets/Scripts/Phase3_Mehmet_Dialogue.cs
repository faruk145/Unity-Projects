using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;
using UnityEngine.UI;
public class Phase3_Mehmet_Dialogue : MonoBehaviour
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



    public bool inDialogueLeftSubTree2 = false;
    public bool inDialogueRighttSubTree2 = false;

    public GameObject canvas; //Yoktu
    void Start()
    {

        loadDialogue1();

    }

    void Update()
    {

    }


    public LipSync m1, m2, m3;
    public LipSyncData MD1, MD2, MD3;




    //ilk mesaj seti
    public void loadDialogue1()
    {
        //Deniz karakter eşleşme
        //Merhaba ben umut
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        rightText.GetComponent<Text>().text = right1;
        m1.Play(MD1, 0f);
        Debug.Log("Deniz karakter eşleşme");
 

    }
    //sol buton ilk set mesajları
    public void loadDialogueLeftSubTree()
    {
        //Her zamanki bilmiş
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        inDialogueLeftSubTree2 = true;
        m2.Play(MD2, 0f);
        Debug.Log("Her zamanki bilmiş");
    }
    //sol buton ikinci mesaj seti
    public void loadDialogueLeftSubTree2()
    {
        //Yavaş yavaş
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left3;

    }
    public void loadDialogueLeftSubTree3()
    {
        //Valla kulağa çok iyi
        leftText.GetComponent<Text>().text = right3;
    }
    //Sağ buton ilk mesaj seti
    public void loadDialogueRightSubTree()
    {
        //Nasıl bu kadar
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = true;
        inDialogueRighttSubTree2 = true;
        m3.Play(MD3, 0f);
        Debug.Log("Nasıl bu kadar");

    }
    //Sağ buton ikinci mesaj seti
    public void loadDialogueRightSubTree2()
    {
        //yanlış yerde
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;

    }
    public void loadDialogueRightSubTree3()
    {
        //Valla elimden
    }
    //BUTONLAR
    //Eğer oyuncu herhangi bir zamanda sol butona basarsa
    public void Left()
    {
        if (inDialogue1)
        {
            loadDialogueLeftSubTree();
        }
        
    }
    //Eğer oyuncu herhangi bir zamanda sağ butona basarsa
    public void Right()
    {
        if (inDialogue1)
        {

            loadDialogueRightSubTree();
        }
 
    }
}
