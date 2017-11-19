using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomWizard : ScriptableWizard {
    [MenuItem("Goodies!/Les 1/Wizard")]
    public static void Open() {
        ScriptableWizard.GetWindow<CustomWizard>();
    }
    protected override bool DrawWizardGUI() {
        return base.DrawWizardGUI();
    }

    private void OnWizardCreate() {
        Debug.Log("Woohoo magic yesh");
    }

}
