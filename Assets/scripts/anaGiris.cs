using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anaGiris : MonoBehaviour
{
    
    public void toplama()
    {
        SceneManager.LoadScene(1);
    }
    public void cikarma()
    {
        SceneManager.LoadScene(2);
    }
    public void carpma()
    {
        SceneManager.LoadScene(3);
    }
    public void bolme()
    {
        SceneManager.LoadScene(4);
    }
}
