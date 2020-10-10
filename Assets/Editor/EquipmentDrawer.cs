using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Equipment))]
public class EquipmentDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight * 6;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        var nameRect = new Rect(position.x, position.y + 18, position.width, 16);
        var valueRect = new Rect(position.x, position.y + 36, position.width, 16);
        var rarityRect = new Rect(position.x, position.y + 54, position.width, 16);
        var slotRect = new Rect(position.x, position.y + 72, position.width, 16);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        var indent = EditorGUI.indentLevel;
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"));
        EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("value"));
        EditorGUI.PropertyField(rarityRect, property.FindPropertyRelative("rarity"));
        EditorGUI.PropertyField(slotRect, property.FindPropertyRelative("slot"));

        EditorGUI.indentLevel = 0;

        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}