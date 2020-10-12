using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InventoryButtons))]
public class InventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        DrawDefaultInspector();

        InventoryButtons inventory = (InventoryButtons)target;

        GUILayout.Label("The Cube's buttons for scale and position");

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Button 1: Increase Size"))
        {
            inventory.ChangeSize();
        }

        if (GUILayout.Button("Button 2: Reset Size"))
        {
            inventory.ResetSize();
        }

        if (GUILayout.Button("Button 3: Move Position"))
        {
            inventory.ChangePosition();
        }

        if (GUILayout.Button("Button 4: Reset Position"))
        {
            inventory.ResetPosition();
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(20.0f);
    }
}
