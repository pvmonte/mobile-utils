using System;
using UnityEngine;

public class EconomyController : MonoBehaviour
{
    public static EconomyController Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }
    
    public void AddCoins(int amount)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + amount);
    }
}
