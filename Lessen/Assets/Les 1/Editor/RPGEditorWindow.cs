using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RPGEditorWindow : EditorWindow {
    public string myString;
    public int myInt;
    public enum MyEnum {Good, bad}
    MyEnum booEnum;
    Color hairColor;
    Color eyeColor;
    float myFloat;

    [MenuItem("Goodies!/Character Window")]
    public static void Open() {
        EditorWindow.GetWindow<RPGEditorWindow>();
    }

    private void OnGUI() {
        GUILayout.Label("My Awesome RPG Character Maker!", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Type characters name!", myString);
        myInt = EditorGUILayout.IntSlider("Age", myInt, 0, 100);
        booEnum = (MyEnum)EditorGUILayout.EnumPopup("Personality", booEnum);
        hairColor = EditorGUILayout.ColorField("Hair Color", hairColor);
        eyeColor = EditorGUILayout.ColorField("Eye Color", eyeColor);
        myFloat = EditorGUILayout.Slider("Length in Meters", myFloat, 0, 2.3f);
    }
}
