using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kacBasamakBolme : MonoBehaviour
{
    public int kacBasamakliIslem = 1;
    public string islemTuru = "BÖLME";
    public static kacBasamakBolme Instance;

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
        SceneManager.LoadScene(8);
    }
    public void IkiBasamakli()
    {
        kacBasamakliIslem = 2;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(8);
    }
    public void UcBasamakli()
    {
        kacBasamakliIslem = 3;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(8);
    }
    public void DortBasamakli()
    {
        kacBasamakliIslem = 4;
        degerTasi.Instance.basamakTasi = kacBasamakliIslem;
        SceneManager.LoadScene(8);
    }
}
