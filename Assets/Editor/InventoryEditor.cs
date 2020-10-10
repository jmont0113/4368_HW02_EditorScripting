using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Buttons))]
public class InventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Buttons buttons = (Buttons)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Increase Size"))
        {
            buttons.ChangeSize();
        }

        if (GUILayout.Button("Reset Size"))
        {
            buttons.ResetSize();
        }

        if (GUILayout.Button("Move Position"))
        {
            buttons.ChangePosition();
        }

        if (GUILayout.Button("Reset Position"))
        {
            buttons.ResetPosition();
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(20.0f);
    }
}
