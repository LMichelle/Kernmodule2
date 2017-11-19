using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ShooClass))]
public class MyCustomPropertyDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        //base.OnGUI(position, property, label);
        //SerializedProperty shoo = property.FindPropertyRelative("shoo");

        position.height = EditorGUIUtility.singleLineHeight * 3;
    }

}
