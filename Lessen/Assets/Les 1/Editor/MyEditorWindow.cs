using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyEditorWindow : EditorWindow {

    [MenuItem("Goodies!/Les 1/EditorWindow")]
    
    public static void Open() {
        EditorWindow.GetWindow<MyEditorWindow>();
    }

    private void OnGUI() {
        GUILayout.Label("Boe!");
    }

}
