using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degerTasi : MonoBehaviour
{
    public int basamakTasi;
    public static degerTasi Instance;

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
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
}
