using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InventoryButtons))]
public class InventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        InventoryButtons inventory = (InventoryButtons)target;

        GUILayout.Label("The inventory's buttons for scale and position");

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Button 1: Increase"))
        {
            inventory.ChangeSize();
        }

        if (GUILayout.Button("Button 2: Reset"))
        {
            inventory.ResetSize();
        }

        if (GUILayout.Button("Button 3: Move"))
        {
            inventory.ChangePosition();
        }

        if (GUILayout.Button("Button 4: Reset"))
        {
            inventory.ResetPosition();
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(20.0f);
    }
}
