using System;
using UnityEngine;

public class NotificationEnabler : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    
    void Start()
    {
        _toggle.OnClick += Toggle_OnClick;
    }

    private void Toggle_OnClick(bool obj)
    {
        throw new NotImplementedException();
    }
}
