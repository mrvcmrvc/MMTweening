﻿using UnityEditor;

[CustomEditor(typeof(MMTweenAlpha))]
public class MMTweenAlphaInspector : InspectorBase<MMTweenAlpha>
{
    private SerializedProperty _easeProperty;

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        _easeProperty = serializedObject.FindProperty("Ease");

        DrawDefaultInspector();

        DrawLoopTypeProperty();

        DrawEaseProperty();

        if (_easeProperty.enumValueIndex == (int)MMTweeningEaseEnum.Curve)
            DrawAnimCurveProperty();

        DrawIsDelayProperty();

        InitOnAwakeProperty();

        DrawDurationProperty();

        DrawIgnoreTimeScaleProperty();

        DrawPlayAutomaticallyProperty();

        serializedObject.ApplyModifiedProperties();
        EditorApplication.update.Invoke();
    }
}