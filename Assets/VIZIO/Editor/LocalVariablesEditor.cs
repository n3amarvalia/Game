//Created by Neodrop
//mailto : neodrop@unity3d.ru
using UnityEngine;
using UnityEditor;
using System.Collections;
//#pragma warning disable

[CustomEditor(typeof(Antares.Vizio.Blocks.LocalVariableInUnityInspector))]
public class LocalVariablesEditor : Editor {

    public override void OnInspectorGUI()
    {
        Antares.Vizio.Blocks.LocalVariableInUnityInspector inspector =
            target as Antares.Vizio.Blocks.LocalVariableInUnityInspector;

        if (inspector)
        {
            foreach (var t in inspector.guiDelegats)
                t();
        }
    }
}
