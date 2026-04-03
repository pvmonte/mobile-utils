using System;
using UnityEngine;

public class VibrationEnabler : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    
    void Start()
    {
        _toggle.OnClick += Toggle_OnClick;
    }

    private void Toggle_OnClick(bool value)
    {
        VibrationController.Instance.SetVibrationEnabled(value);
    }
}
