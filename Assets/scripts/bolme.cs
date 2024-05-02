using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bolme : MonoBehaviour
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
        basamak = kacBasamakBolme.Instance.kacBasamakliIslem;
        if (fonksiyonDonsunMu == true)
        {
            bolmeIslemi();
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



    //1*1,  1*4     , 1-4 (1-4)
    //2*2,  2*24    , 4-48 (3-49)
    //3*1,  3*166   , 3-498 (3-499)
    //4*1,  4*1249  , 4-4996 (3-4999)
    void bolmeIslemi()
    {
        if (basamak == 1)
        {
            int sayi1 = Random.Range(2, 10);
            List<int> bolenler = new List<int>(); //kaç bölen olacaðýný bilmediðimiz için list tanýmladým
            for (int i = 2; i <= sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    bolenler.Add(i);
                }
            }
            int sayi2 = bolenler[Random.Range(0, bolenler.Count)];
            toplam = sayi1 / sayi2;
            Debug.Log(sayi1 + "/" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " / " + sayi2.ToString();
            katSayi1 = 1; katSayi2 = 4;
        }
        else if (basamak == 2)
        {
            int sayi1 = Random.Range(10, 100);
            List<int> bolenler = new List<int>(); //kaç bölen olacaðýný bilmediðimiz için list tanýmladým
            for (int i = 2; i <= sayi1; i++)
            {
                if (sayi1 % i == 0 && sayi1 != i)
                {
                    bolenler.Add(i);
                }
            }
            int sayi2 = bolenler[Random.Range(0, bolenler.Count)];
            toplam = sayi1 / sayi2;
            Debug.Log(sayi1 + "/" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " / " + sayi2.ToString();
            katSayi1 = 2; katSayi2 = 24;
        }
        else if (basamak == 3)
        {
            int sayi1 = Random.Range(100, 1000);
            List<int> bolenler = new List<int>(); //kaç bölen olacaðýný bilmediðimiz için list tanýmladým
            for (int i = 2; i <= sayi1; i++)
            {
                if (sayi1 % i == 0 && sayi1 != i)
                {
                    bolenler.Add(i);
                }
            }
            int sayi2 = bolenler[Random.Range(0, bolenler.Count)];
            toplam = sayi1 / sayi2;
            Debug.Log(sayi1 + "/" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " / " + sayi2.ToString();
            katSayi1 = 1; katSayi2 = 166;
        }
        else if (basamak == 4)
        {
            int sayi1 = Random.Range(1000, 8000); //bilerek azaltýldý
            List<int> bolenler = new List<int>(); //kaç bölen olacaðýný bilmediðimiz için list tanýmladým
            for (int i = 2; i <= sayi1; i++)
            {
                if (sayi1 % i == 0 && sayi1 != i)
                {
                    bolenler.Add(i);
                }
            }
            int sayi2 = bolenler[Random.Range(0, bolenler.Count)];
            toplam = sayi1 / sayi2;
            Debug.Log(sayi1 + "/" + sayi2 + "=" + toplam); //HATA AYIKLAMA
            ekran.text = sayi1.ToString() + " / " + sayi2.ToString();
            katSayi1 = 1; katSayi2 = 1249;
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
