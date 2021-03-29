using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LightBuilder))]
public class LightBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Space(10);

        LightBuilder spawningArea = (LightBuilder)target;
        if (GUILayout.Button("BuildLight"))
        {
            EditorUtility.SetDirty(target);
            spawningArea.BuildLight();
        }

        if (GUILayout.Button("ClearLight"))
        {
            EditorUtility.SetDirty(target);
            spawningArea.ClearLight();
        }
        if (GUILayout.Button("ActivateLight"))
        {
            EditorUtility.SetDirty(target);
            spawningArea.ActivateLight();
        }
        if (GUILayout.Button("DeactivateLight"))
        {
            EditorUtility.SetDirty(target);
            spawningArea.DeactivateLight();
        }
    }
}