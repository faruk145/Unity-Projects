using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;
using UnityEngine.UI;

public class Phase3_Mission_Dialogues : MonoBehaviour
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

    public string left5, right5;
    public string left6, right6;
    public string left7, right7;
    public string left8, right8;
    public string left9, right9;
    public string left10, right10;
    public string left11, right11;
    public string left12, right12;
    public string left13, right13;

    public bool inDialogueRightSubTree2 = false;
    public bool inDialogueLeftSubTree2 = false;
    public bool inDialogueRightSubTree3 = false;
    public bool inDialogueLeftSubTree3 = false;
    public bool inDialogueRightSubTree4 = false;
    public bool inDialogueLeftSubTree4 = false;
    public bool inDialogueLeftSubTree5 = false;
    public bool inDialogueRightSubTree5 = false;
    public bool inDialogueRightSubTree6 = false;
    public bool inDialogueRightSubTree7 = false;
    public bool inDialogueRightSubTree8 = false;

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


    public LipSync a1,a2,a3,a4,a5,a6,a7,a8,a9,m1,m2,m3,m4,m5,m6,m7,m8;
    public LipSyncData AD1,AD2,AD3,AD4,AD5,AD6,AD7,AD8,AD9,MD1,MD2,MD3,MD4,MD5,MD6,MD7,MD8;

    

    public void Quit()
    {
        Application.Quit();
    }


    //ilk mesaj seti
    public void loadDialogue1()
    {
        inDialogue1 = true;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        leftText.GetComponent<Text>().text = left1;
        rightText.GetComponent<Text>().text = right1;
        a1.Play(AD1, 6f);
        Debug.Log("Biraz yardim(Ayca)");
        
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
        m1.Play(MD1, 1f);
        a2.Play(AD2, 8f);
        Debug.Log("Bence de öyle(Mehmet),Sıkıntı nerede(Ayca)");



    }
    //sol buton ikinci mesaj seti
    public void loadDialogueLeftSubTree2()
    {
        inDialogue1 = false;
        inDialogueLeftSubTree = false; //inDialogueLeftSubTree = true;
        inDialogueRightSubTree = false;
        //canvas.SetActive(false);//leftText.GetComponent<Text>().text = left3;
        
        //rightText.GetComponent<Text>().text = right3;

    }
    //Sağ buton ilk mesaj seti
    public void loadDialogueRightSubTree()
    {
        //Ayca:Aslına bakarsan Mehmet:Yine de elemeler
        //RightResponse();
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = true;
        leftText.GetComponent<Text>().text = left4;
        rightText.GetComponent<Text>().text = right4;
        a4.Play(AD4, 0f);
        m3.Play(MD3, 15f);
        Debug.Log("%80(Ayca),Yine de elemeler(Mehmet)");

    }
    //Sağ buton ikinci mesaj seti
    public void loadDialogueRightSubTree2()
    {
        //Ayca:Bence sifirlari  Mehmet:Bence de ilk aşama
        inDialogue1 = false;
        inDialogueLeftSubTree = false;
        inDialogueRightSubTree = false;
        inDialogueRightSubTree4 = false;
        leftText.GetComponent<Text>().text = left5;
        rightText.GetComponent<Text>().text = right5;
        inDialogueRightSubTree2 = true;
        a3.Play(AD3, 0f); 
        m2.Play(MD2, 10f);
        Debug.Log("Bence sifirlari testpi edip(Ayca),Bence de ilk aşamada sıfır ve 1 sayisini tesopit etmek(Mehmet)");
    }
    public void loadDialogueLeftSubTree3()
    {
        //Ayca:2. yolda    Mehmet:Bence en baştan
        inDialogueLeftSubTree2 = true;
        inDialogueRightSubTree2 = false;
        inDialogueRightSubTree = false;
        inDialogueRightSubTree6 = true;
        leftText.GetComponent<Text>().text = left6;
        rightText.GetComponent<Text>().text = right6;
        a5.Play(AD5, 0f);
        m4.Play(MD4, 7f);
        Debug.Log("2.yolda bir sikinti(Ayca),Bence en baştan(Mehmet)");

    }
    public void loadDialogueLeftSubTree4()
    {
        //Mehmet:En başta her girdi  Ayca:İşi uzatır gibi
        inDialogueLeftSubTree3 = true;
        inDialogueLeftSubTree2 = false;
        leftText.GetComponent<Text>().text = left7;
        rightText.GetComponent<Text>().text = right7;
        m5.Play(MD5, 0f);
        a6.Play(AD6, 6f);
        Debug.Log("En başta her girdi(Mehmet),İşi uzatır gibi(Ayca)");
    }
    public void loadDialogueLeftSubTree5()
    {
        //Güzel nokta(Mehmet)
        inDialogueLeftSubTree4 = true;
        leftText.GetComponent<Text>().text = left9;
        rightText.GetComponent<Text>().text = right9;
        m7.Play(MD7, 0f);
        Debug.Log("Güzel nokta(Mehmet)");
    }
    public void loadDialogueRightSubTree3()
    {
        //Mehmet:Tam olarak kastın nedir
        inDialogueRightSubTree4 = true;
        inDialogue1 = false;
        leftText.GetComponent<Text>().text = left8;
        rightText.GetComponent<Text>().text = right8;
        m6.Play(MD6, 0f);
        Debug.Log("Mehmet:Tam olarak kastın nedir");

    }
    public void loadDialogueLeftSubTree6()
    {
        //Hepsi için ayrı ayrı(Mehmet),Aslında toplam arama(Ayca)
        inDialogueLeftSubTree5 = true;
        leftText.GetComponent<Text>().text = left10;
        rightText.GetComponent<Text>().text = right10;
        m8.Play(MD8, 0f);
        a7.Play(AD7, 5f);
        Debug.Log("Hepsi için ayrı ayrı(Mehmet),Aslında toplam arama(Ayca)");
    }
    public void loadDialogueRightSubTree4()
    {
        //İkinci yolun tam sikintisi
        inDialogueRightSubTree5 = true;
        leftText.GetComponent<Text>().text = left11;
        rightText.GetComponent<Text>().text = right11;
        a8.Play(AD8, 0f);
        Debug.Log("İkinci yolun tam sikintisi");

    }
    public void loadDialogueRightSubTree5()
    {
        //Güzel nokta (Ayca)
        inDialogueRightSubTree7 = true;
        leftText.GetComponent<Text>().text = left12;
        rightText.GetComponent<Text>().text = right12;
        a9.Play(AD9, 0f);
        Debug.Log("Güzel nokta (Ayca)");
    }
    public void loadDialogueRightSubTree6()
    {
        inDialogueRightSubTree8 = true;
        leftText.GetComponent<Text>().text = left13;
        rightText.GetComponent<Text>().text = right13;
        Debug.Log("Son butonlar");
        canvas.SetActive(true);
    }
    //BUTONLAR
    //Eğer oyuncu herhangi bir zamanda sol butona basarsa
    public void Left()
    {
        if (inDialogue1)
        {
            loadDialogueLeftSubTree();
        }
        else if (inDialogueRightSubTree4)
        {
            loadDialogueRightSubTree2();
        }
        else if (inDialogueLeftSubTree)
        {

            loadDialogueRightSubTree2();

        }
        else if (inDialogueRightSubTree)
        {

            loadDialogueLeftSubTree3();
        }
        else if (inDialogueRightSubTree2)
        {
            loadDialogueRightSubTree();
        }
        else if (inDialogueLeftSubTree2)
        {
            loadDialogueLeftSubTree4();
            inDialogueLeftSubTree2 = false;
        }
        else if (inDialogueLeftSubTree3)
        {
            loadDialogueLeftSubTree5();
            inDialogueLeftSubTree3 = false;
        }
        else if (inDialogueLeftSubTree4)
        {
            loadDialogueLeftSubTree6();
            inDialogueLeftSubTree4 = false;
            //canvas.SetActive(false);
            //EndCanvas.SetActive(true);
        }
        else if (inDialogueRightSubTree5)
        {
            loadDialogueRightSubTree5();
            inDialogueRightSubTree5 = false;
        }
         else if (inDialogueRightSubTree7)
        {
            loadDialogueRightSubTree6();
            inDialogueRightSubTree7 = false;
            //canvas.SetActive(false);
            //EndCanvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
            EndCanvas.SetActive(true);
        }
  
    }
    //Eğer oyuncu herhangi bir zamanda sağ butona basarsa
    public void Right()
    {
        if (inDialogue1)
        {

            loadDialogueRightSubTree3();
        }
        else if (inDialogueLeftSubTree)
        {
            
            loadDialogueRightSubTree2();
        }
        else if (inDialogueRightSubTree)
        {
            loadDialogueLeftSubTree3();
            
        }
        else if (inDialogueRightSubTree2)
        {
            loadDialogueRightSubTree();
        }
        else if (inDialogueLeftSubTree3)
        {
            loadDialogueLeftSubTree5();
            inDialogueLeftSubTree3 = false;
        }
        else if (inDialogueLeftSubTree4)
        {
            loadDialogueLeftSubTree6();
            inDialogueLeftSubTree4 = false;
            //canvas.SetActive(false);
            //EndCanvas.SetActive(true);
        }
        else if (inDialogueRightSubTree6)
        {
            loadDialogueRightSubTree4();
            inDialogueLeftSubTree2 = false;
            inDialogueRightSubTree6 = false;
        }
        else if (inDialogueRightSubTree5)
        {
            loadDialogueRightSubTree5();
            inDialogueRightSubTree5 = false;
        }
        else if (inDialogueRightSubTree7)
        {
            loadDialogueRightSubTree6();
            inDialogueRightSubTree7 = false;
            //canvas.SetActive(false);
            //EndCanvas.SetActive(true);
        }
        else if (inDialogueRightSubTree4)
        {
            loadDialogueRightSubTree2();
            inDialogueRightSubTree4 = false;
        }
        else
        {
            canvas.SetActive(false);
            EndCanvas.SetActive(true);
        }
    }
   
}
