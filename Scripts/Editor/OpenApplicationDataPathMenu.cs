using System.IO;
using UnityEditor;
using UnityEngine;

public static class OpenApplicationDataPathMenu
{
    [MenuItem("Tools/Local Saving/Open Application Data Path")]
    private static void OpenApplicationDataPath()
    {
        string path = Application.persistentDataPath;

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        EditorUtility.RevealInFinder(path);
    }
}
