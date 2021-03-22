using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;
using UnityEngine.UI;
using TMPro;

public class Phase4_Dialogues : MonoBehaviour
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

    public string left5,right5;
    

    public bool inDialogueLeftSubTree2 = false;
    public bool inDialogueRighttSubTree2 = false;

    public GameObject canvas, button; //Yoktu
    void Start()
    {

        loadDialogue1();

    }

    void Update()
    {

    }


    public LipSync g1,g2,g3,g4,g5,g6,g7;
    public LipSyncData GD1, GD2, GD3, GD4, GD5, GD6, GD7;




    //ilk mesaj seti
    public void loadDialogue1()
    {
        //Merhaba ben umut
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        rightText.GetComponent<Text>().text = right1;
        g1.Play(GD1, 0f);
        Debug.Log("Merhaba ben umut");

    }
    //sol buton ilk set mesajları
    public void loadDialogueLeftSubTree()
    {
        //Simülasyon mu
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        inDialogueLeftSubTree2 = true;
        leftText.GetComponent<Text>().text = left2_Left;
        rightText.GetComponent<Text>().text = right2_Left;
        g2.Play(GD2, 0f);
        Debug.Log("Simülasyon mu");

    }
    //sol buton ikinci mesaj seti
    public void loadDialogueLeftSubTree2()
    {
        //Yavaş yavaş
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        g3.Play(GD3, 0f);
        Debug.Log("Yavaş yavaş");
        leftText.GetComponent<Text>().text = left3;
        button.SetActive(false);

    }
    public void loadDialogueLeftSubTree3()
    {
        //Valla kulağa çok iyi
        g4.Play(GD4, 0f);
        Debug.Log("Valla kulağa çok iyi");
        leftText.GetComponent<Text>().text = right3;
        button.SetActive(false);
    }
    //Sağ buton ilk mesaj seti
    public void loadDialogueRightSubTree()
    {
        //Ya aslı hanım
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = true;
        inDialogueRighttSubTree2 = true;
        leftText.GetComponent<Text>().text = left4;
        rightText.GetComponent<Text>().text = right4;
        g5.Play(GD5, 0f);
        Debug.Log("Ya aslı hanım");


    }
    //Sağ buton ikinci mesaj seti
    public void loadDialogueRightSubTree2()
    {
        //yanlış yerde
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        g6.Play(GD6, 0f);
        Debug.Log("yanlış yerde");
        leftText.GetComponent<Text>().text = left5;
        button.SetActive(false);

    }
    public void loadDialogueRightSubTree3()
    {
        //Valla elimden
        leftText.GetComponent<Text>().text = right5;
        button.SetActive(false);
        g7.Play(GD7, 0f);
        Debug.Log("Valla elimden");
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
            loadDialogueLeftSubTree2();
            inDialogueLeftSubTree = false;
        }

        else if (inDialogueRightSubTree)
        {
            inDialogueRightSubTree = false;

        }
        else if (inDialogueRighttSubTree2)
        {
            loadDialogueRightSubTree3();
            inDialogueRighttSubTree2 = false;
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

            
        }
        else if (inDialogueRightSubTree)
        {
            loadDialogueRightSubTree2();
            inDialogueRightSubTree = false;
        }
        else if (inDialogueLeftSubTree2)
        {
            loadDialogueLeftSubTree3();
            inDialogueLeftSubTree2 = false;
        }
    }
}
