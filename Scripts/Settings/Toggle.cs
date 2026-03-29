using System;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    [SerializeField] private Button _toggleButton;
    private bool value;

    public event Action<bool> OnClick; 
    
    void Awake()
    {
        _toggleButton.onClick.AddListener(Call);
    }

    private void Call()
    {
        value = !value;
        OnClick?.Invoke(value);
    }
}
