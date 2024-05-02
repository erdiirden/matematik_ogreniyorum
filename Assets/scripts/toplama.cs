using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toplama : MonoBehaviour
{
    private int toplam,katSayi1,katSayi2;
    public int basamak;
    private bool fonksiyonDonsunMu = true;
    public Text ekran;
    public Text[] cevapText = new Text[4];
    public GameObject green, red;
    void Start()
    {
        
    }

    void Update()
    {
        basamak = kacBasamakToplama.Instance.kacBasamakliIslem;
        if (fonksiyonDonsunMu == true)
        {
            toplamaIslemi();
            fonksiyonDonsunMu=false;
            int cevapSikki = Random.Range(0, 4); //CEVABIN HANGÝ ÞIKA OLACAÐINI RANDOM BELÝRLEME
            cevapText[cevapSikki].text = toplam.ToString(); //RANDOM ÞIKKIN TEXTÝNE DOÐRU CEVABI EKLEME
            for (int i = 0; i < 4; i++) //DOÐRU CEVAP HARÝÇ DÝÐER ÞIKLARIN KONTROLÜ
            {
                if (cevapText[i].text == "0")
                {
                    cevapText[i].text = Random.Range(basamak*katSayi1, basamak*katSayi2).ToString(); //DOÐRU CEVAP HARÝÇ DÝÐER ÞIKLARA RANDOM DEÐERLER VERME
                }
            }
        }
    }

    //1*4,  1*16     , 4-16 (0-18)
    //2*20,  2*80     , 40-160 (20-198)
    //3*117, 3*500   , 351-1500 (200-1998)
    //4*750,4*3750  , 3000-15000 (2000-19998)
    void toplamaIslemi()
    {
        if (basamak == 1)
        {
            int sayi1 = Random.Range(0, 10);
            int sayi2 = Random.Range(0, 10);
            toplam = sayi1 + sayi2;
            Debug.Log(sayi1 +"+"+ sayi2+"="+ toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " + " + sayi2.ToString();
            katSayi1 = 4; katSayi2 = 16;
        }
        else if (basamak == 2)
        {
            int sayi1 = Random.Range(10, 100);
            int sayi2 = Random.Range(10, 100);
            toplam = sayi1 + sayi2;
            Debug.Log(sayi1 + "+" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " + " + sayi2.ToString();
            katSayi1 = 20; katSayi2 = 80;
        }
        else if (basamak == 3)
        {
            int sayi1 = Random.Range(100, 1000);
            int sayi2 = Random.Range(100, 1000);
            toplam = sayi1 + sayi2;
            Debug.Log(sayi1 + "+" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " + " + sayi2.ToString();
            katSayi1 = 117; katSayi2 = 500;
        }
        else if (basamak == 4)
        {
            int sayi1 = Random.Range(1000, 10000);
            int sayi2 = Random.Range(1000, 10000);
            toplam = sayi1 + sayi2;
            Debug.Log(sayi1 + "+" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " + " + sayi2.ToString();
            katSayi1 = 750; katSayi2 = 3750;
        }
        else
        {
            //islem yok
        }
    }


    //CEVAP BUTONLARI FONKSÝYONLARI
    public void cevapA()
    {
        if (cevapText[0].text==toplam.ToString())
        {
            Debug.Log(cevapText[0].text + "-----bura eþit çýkmalý-------" + toplam.ToString());
            //++
            green.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
        else
        {
            red.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
    }
    public void cevapB()
    {
        if (cevapText[1].text == toplam.ToString())
        {
            Debug.Log(cevapText[1].text + "-----bura eþit çýkmalý-------" + toplam.ToString());
            //++
            green.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
        else
        {
            red.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
    }
    public void cevapC()
    {
        if (cevapText[2].text == toplam.ToString())
        {
            Debug.Log(cevapText[2].text + "-----bura eþit çýkmalý-------" + toplam.ToString());
            //++
            green.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
        else
        {
            red.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
    }
    public void cevapD()
    {
        if (cevapText[3].text == toplam.ToString())
        {
            Debug.Log(cevapText[3].text + "-----bura eþit çýkmalý-------" + toplam.ToString());
            //++
            green.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
        else
        {
            red.SetActive(true);
            StartCoroutine(gecikmeSahne());
        }
    }
    IEnumerator gecikmeSahne()
    {
        yield return new WaitForSeconds(.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
