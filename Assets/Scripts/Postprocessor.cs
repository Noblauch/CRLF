using UnityEditor;
using UnityEngine;

public class Postprocessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets,
        string[] movedFromAssetPaths)
    {
        foreach (string str in importedAssets)
            if (str.EndsWith(".prefab"))
                PostprocessPrefab(str);
    }
    
    static void PostprocessPrefab(string prefabPath)
    {
        Debug.Log("PP " + prefabPath);
        var prefabRoot = AssetDatabase.LoadMainAssetAtPath(prefabPath) as GameObject;
        PrefabUtility.SavePrefabAsset(prefabRoot);
    }
}