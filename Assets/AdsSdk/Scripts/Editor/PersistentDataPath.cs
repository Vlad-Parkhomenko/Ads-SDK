using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class PersistentDataPath
{
    [MenuItem("Tools/Open persistent data path")]
    private static void OpenPesritentDataPath()
    {
        Process.Start(Application.persistentDataPath);
    }
}
