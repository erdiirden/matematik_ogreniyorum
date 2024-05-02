using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kacBasamakToplama : MonoBehaviour
{
    public int kacBasamakliIslem=1;
    public string islemTuru = "TOPLAMA";
    public static kacBasamakToplama Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void BirBasamakli()
    {
        kacBasamakliIslem = 1;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(5);
    }
    public void IkiBasamakli()
    {
        kacBasamakliIslem = 2;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(5);
    }
    public void UcBasamakli()
    {
        kacBasamakliIslem = 3;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(5);
    }
    public void DortBasamakli()
    {
        kacBasamakliIslem = 4;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(5);
    }
}
