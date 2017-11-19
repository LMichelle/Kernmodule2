using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


// custom inspectors draw how a class fields should look.
// property drawers draw how a property should look.

[CustomEditor(typeof(BooClass))]
public class BooCustomEditor : Editor {
    public override void OnInspectorGUI() {
        serializedObject.Update();
        DrawPropertiesExcluding(serializedObject, "m_Script");

        EditorGUILayout.HelpBox("Woohoo Helpbox", MessageType.Warning);
        GUILayout.Button("Boe", GUILayout.Width(150));
        EditorGUILayout.IntSlider("Slider!", 40, 0, 100);

        serializedObject.ApplyModifiedProperties();
    }
}
