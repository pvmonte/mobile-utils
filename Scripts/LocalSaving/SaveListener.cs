using System;
using UnityEngine;

public class SaveListener<T> : MonoBehaviour
{
    private ISaveable<T> _saveable;
    
    void Start()
    {
        _saveable = GetComponent<ISaveable<T>>();
        _saveable.OnSavePointReached += Saveable_OnSavePointReached;
    }

    private void Saveable_OnSavePointReached(T data)
    {
        SaveSystem.Save(data);
    }

    private void OnDestroy()
    {
        _saveable.OnSavePointReached -= Saveable_OnSavePointReached;
    }
}
