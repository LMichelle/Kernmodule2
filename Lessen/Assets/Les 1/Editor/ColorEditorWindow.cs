using UnityEditor;
using UnityEngine;

public class ColorEditorWindow : EditorWindow {
    // Muchos Thanks to Brackeys

    public string myString;
    Color color;

    [MenuItem("Goodies!/Colorize")]
    public static void Open() {
        EditorWindow.GetWindow<ColorEditorWindow>();
    }

    private void OnGUI() {
        GUILayout.Label("Brackeys ways to colorizing everything", EditorStyles.boldLabel);
        color = EditorGUILayout.ColorField("Color", color);

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Color me!")) {
            foreach (GameObject obj in Selection.gameObjects) {
                Renderer render = obj.GetComponent<Renderer>();
                if (render != null) {
                    render.sharedMaterial.color = color;
                }
            }
        }

        if (GUILayout.Button("Random Color!")) {
            foreach (GameObject obj in Selection.gameObjects) {
                Renderer render = obj.GetComponent<Renderer>();
                if (render != null) {
                    color = Random.ColorHSV();
                    render.sharedMaterial.color = color;
                }
            }
        }
        if (GUILayout.Button("Reset")) {
            foreach (GameObject obj in Selection.gameObjects) {
                Renderer render = obj.GetComponent<Renderer>();
                if (render != null) {
                    color = Color.white;
                    render.sharedMaterial.color = color;
                }
            }
        }
        GUILayout.EndHorizontal();
    }
}