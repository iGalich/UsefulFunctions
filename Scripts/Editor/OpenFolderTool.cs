using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class OpenFolderTool
{
    [OnOpenAsset]
    public static bool OnOpenAsset(int instanceId)
    {
        Event e = Event.current;

        if (e == null || !e.shift)
        {
            return false;
        }

        Object obj = EditorUtility.InstanceIDToObject(instanceId);
        string path = AssetDatabase.GetAssetPath(obj);
        
        if (AssetDatabase.IsValidFolder(path))
        {
            EditorUtility.RevealInFinder(path);
        }

        return true;
    }
}