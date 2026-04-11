using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void Save<T>(T data)
    {
        string path = Application.persistentDataPath + "/" + typeof(T).Name + ".dat";
        FileStream stream = File.Open(path, FileMode.Create);

        if (stream == null)
        {
            Debug.Log("Data is null");
            return;
        }
        
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, data);
    }
    
    public static T Load<T>()
    {
        string path = Application.persistentDataPath + "/" + typeof(T).Name + ".dat";
        
        if (!File.Exists(path)) return default(T);
        
        FileStream stream = File.Open(path, FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        return (T)formatter.Deserialize(stream);
    }
}

public interface ISaveable<T>
{
    public event Action<T> OnSavePointReached;
}

public interface ILoadable<T>
{
    public event Func<T> OnLoadPointReached;
}