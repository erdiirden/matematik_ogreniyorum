using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class carpma : MonoBehaviour
{
    private int toplam, katSayi1, katSayi2;
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
        basamak = kacBasamakCarpma.Instance.kacBasamakliIslem;
        if (fonksiyonDonsunMu == true)
        {
            carpmaIslemi();
            fonksiyonDonsunMu = false;
            int cevapSikki = Random.Range(0, 4); //CEVABIN HANGÝ ÞIKA OLACAÐINI RANDOM BELÝRLEME
            cevapText[cevapSikki].text = toplam.ToString(); //RANDOM ÞIKKIN TEXTÝNE DOÐRU CEVABI EKLEME
            for (int i = 0; i < 4; i++) //DOÐRU CEVAP HARÝÇ DÝÐER ÞIKLARIN KONTROLÜ
            {
                if (cevapText[i].text == "0")
                {
                    cevapText[i].text = Random.Range(basamak * katSayi1, basamak * katSayi2).ToString(); //DOÐRU CEVAP HARÝÇ DÝÐER ÞIKLARA RANDOM DEÐERLER VERME
                }
            }
        }
    }



    //1*1,  1*70     , 1-70 (1-81)
    //2*20,  2*330   , 40-660 (10-891)
    //3*90, 3*3300   , 270-6600 (100-8991)
    //4*800,4*16000    , 3200-64000 (1000-71991)
    void carpmaIslemi()
    {
        if (basamak == 1)
        {
            int sayi1 = Random.Range(1, 10);
            int sayi2 = Random.Range(1, 10);
            toplam = sayi1 * sayi2;
            Debug.Log(sayi1 + "*" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " * " + sayi2.ToString();
            katSayi1 = 1; katSayi2 = 70;
        }
        else if (basamak == 2)
        {
            int sayi1 = Random.Range(10, 100);
            int sayi2 = Random.Range(1, 10); //tek basamakli bilerek
            toplam = sayi1 * sayi2;
            Debug.Log(sayi1 + "*" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " * " + sayi2.ToString();
            katSayi1 = 20; katSayi2 = 330;
        }
        else if (basamak == 3)
        {
            int sayi1 = Random.Range(100, 1000);
            int sayi2 = Random.Range(1, 10);
            toplam = sayi1 * sayi2;
            Debug.Log(sayi1 + "*" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " * " + sayi2.ToString();
            katSayi1 = 90; katSayi2 = 3300;
        }
        else if (basamak == 4)
        {
            int sayi1 = Random.Range(1000, 8000); //bilerek azaltýldý
            int sayi2 = Random.Range(1, 10);
            toplam = sayi1 * sayi2;
            Debug.Log(sayi1 + "*" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " * " + sayi2.ToString();
            katSayi1 = 800; katSayi2 = 16000;
        }
        else
        {
            //islem yok
        }
    }

    //CEVAP BUTONLARI FONKSÝYONLARI
    public void cevapA()
    {
        if (cevapText[0].text == toplam.ToString())
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
