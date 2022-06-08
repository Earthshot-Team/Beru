using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScaleTopBarUI))]
public class ScaleTopBarUIEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Space(5f);

        if (GUILayout.Button("Reload TextBox Size"))
        {
            (target as ScaleTopBarUI).ReloadTextBoxSize();
        }

        GUILayout.Space(5f);

        if (GUILayout.Button("Set Text"))
        {
            (target as ScaleTopBarUI).SetText();
        }
    }
}
