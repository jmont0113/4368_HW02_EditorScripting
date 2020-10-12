using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class HelpBoxAttribute : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.HelpBox("Adjust the inventory settings by adding an item name, " +
            "defense/attack rating, rarity, and slot", MessageType.Warning);
    }
}