using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using RogoDigital.Lipsync;

[RequireComponent(typeof(AudioSource))]
public class SceneManager : MonoBehaviour
{

    /*public float bpm = 90.0f;
    public int numBeatsPerSegment = 16;
    public AudioClip[] clips = new AudioClip[3];
    private double nextEventTime;
    private int flip = 0;
    private AudioSource[] audioSources = new AudioSource[3];
    private bool running = false;
    public float bpm1 = 90.0f;
    public int numBeatsPerSegment1 = 16;
    public AudioClip[] clips1 = new AudioClip[3];
    private double nextEventTime1;
    private int flip1 = 0;
    private AudioSource[] audioSources1 = new AudioSource[3];
    private bool running1 = false;
    public bool lft1 = false;
    public static bool trigger1 = false;
    public float bpm2 = 90.0f;
    public int numBeatsPerSegment2 = 16;
    public AudioClip[] clips2 = new AudioClip[1];
    private double nextEventTime2;
    private int flip2 = 0;
    private AudioSource[] audioSources2 = new AudioSource[1];
    private bool running2 = false;
    public bool lft2 = false;*/

    



    public static bool inRange = false;//Oyuncu Npc alanına girince aktif olacak
    public static bool inChat = false;//chat penceresi içi ve disinda aktifliği değişiyo
    public bool inDialogue1 = true;
    public bool inDialogueLeftSubTree = false;
    public bool inDialogueRightSubTree = false;
    [Header("Objects")]
    public GameObject npcWindow;
    public Text chatText;
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


    

    public GameObject canvas; //Yoktu
    void Start()
    {
        
        

    }

    void Update()
    {
        
    }


    public LipSync a_left, m1_left;
    public LipSyncData aleft, m1left;

    public LipSync a_right, m1_right;
    public LipSyncData aright, m1right;

    public LipSync mehmet_response_right, mehmet_response_left;
    public LipSyncData senden_korkulur_left, senden_korkulur_right;

    public LipSync mehmet_response_leftsubtree_left, mehmet_response_leftsubtree_right;
    public LipSyncData is_kitlemek_left, is_kitlemek_right;

    public void MehmetIsKitlemek_Left()
    {
        mehmet_response_leftsubtree_left.Play(is_kitlemek_left, 1f);
    }
    public void MehmetIsKitlemek_Right()
    {
        mehmet_response_leftsubtree_right.Play(is_kitlemek_right, 1f);
    }

    public void MehmetResponseRight()
    {
        mehmet_response_right.Play(senden_korkulur_right, 1f);
    }
    public void MehmetResponseLeft()
    {
        mehmet_response_left.Play(senden_korkulur_left, 1f);
    }


    //ilk mesaj seti
    public void loadDialogue1()
    {
        inChat = true;
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        rightText.GetComponent<Text>().text = right1;
    }
    //sol buton ilk set mesajları
    public void loadDialogueLeftSubTree()
    {
        LeftResponse();
        inDialogue1 = false;
        inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left2_Left;
        rightText.GetComponent<Text>().text = right2_Left;

    }
    //sol buton ikinci mesaj seti
    public void loadDialogueLeftSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false; //inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        canvas.SetActive(false);//leftText.GetComponent<Text>().text = left3;
        upText.GetComponent<Text>().text = "";
        //rightText.GetComponent<Text>().text = right3;

    }
    //Sağ buton ilk mesaj seti
    public void loadDialogueRightSubTree()
    {
        RightResponse();
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = true;
        leftText.GetComponent<Text>().text = left4;
        rightText.GetComponent<Text>().text = right4;
        


    }
    //Sağ buton ikinci mesaj seti
    public void loadDialogueRightSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        //leftText.GetComponent<Text>().text = "";
        //upText.GetComponent<Text>().text = "";
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
            MehmetIsKitlemek_Left();
            loadDialogueLeftSubTree2();

        }
        else if (inDialogueRightSubTree)
        {
            loadDialogueRightSubTree2();
            MehmetResponseLeft();
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
            MehmetIsKitlemek_Right();
            //chatText.GetComponent<Text>().text = rightResponse2;
            loadDialogueLeftSubTree2();
        }
        else if (inDialogueRightSubTree)
        {

            loadDialogueRightSubTree2();
            MehmetResponseRight();
            canvas.SetActive(false);
        }
    }
    public void LeftResponse()
    {
        a_left.Play(aleft, 1f);
        m1_left.Play(m1left, 8f);
    }
    public void RightResponse()
    {
        a_right.Play(aright, 1f);
        m1_right.Play(m1right, 8f);
    }

}

