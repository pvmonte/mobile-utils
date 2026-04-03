using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class NotificationController : MonoBehaviour
{
    public static NotificationController Instance { get; private set; }
    private bool _isNotificationEnabled = true;
    
    private void Awake()
    {
        if (Instance is null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        StartCoroutine(RequestNotificationPermission());
    }
    
    private IEnumerator RequestNotificationPermission()
    {
        var request = new PermissionRequest();
        while (request.Status == PermissionStatus.RequestPending)
            yield return null;
        // here use request.Status to determine user's response
    }


    public void SetNotificationEnabled(bool enabled)
    {
        _isNotificationEnabled = enabled;
    }
}
