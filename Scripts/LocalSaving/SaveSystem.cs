using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void Save<T>(T data)
    {
        string path = Application.persistentDataPath + "/" + typeof(T).Name + ".dat";
        using (FileStream stream = File.Open(path, FileMode.Create))
        {
            if (stream == null)
            {
                Debug.Log("Data is null");
                return;
            }
            
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
        }

#if UNITY_EDITOR
        SaveJson(data);
#endif
    }
    
    public static T Load<T>()
    {
        string path = Application.persistentDataPath + "/" + typeof(T).Name + ".dat";
        
        if (!File.Exists(path)) return default(T);
        
        using (FileStream stream = File.Open(path, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (T)formatter.Deserialize(stream);
        }
    }

#if UNITY_EDITOR
    private static void SaveJson<T>(T data)
    {
        string path = Application.persistentDataPath + "/" + typeof(T).Name + ".json";
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
    }
#endif
}

public interface ISaveable<T>
{
    public event Action<T> OnSavePointReached;
}

public interface ILoadable<T>
{
    public event Func<T> OnLoadPointReached;
}
