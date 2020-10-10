using UnityEngine;
using UnityEditor;

public class HelpBoxExample : EditorWindow
{
    [MenuItem("Window/Help Box")]
    public static void ShowWindow()
    {
        GetWindow<HelpBoxExample>("HelpBox");
    }

    void OnGUI()
    {
        EditorGUILayout.HelpBox("Adjust the inventory settings by adding to an item name, " +
            "defense/attack rating, rarity, and slot", MessageType.Warning);
    }
}