//Created by Neodrop
//mailto : neodrop@unity3d.ru
using Antares;
using Antares.Vizio.Editor;
using UnityEngine;
using UnityEditor;
using System.Collections;
//#pragma warning disable

[CustomEditor(typeof(TextAsset))]
public class VizioTextAssetsCustomEditor : VizioTextAssetsCustomEditorInteranl
{
    public override void OnDrawDefaultInspector()
    {
        DrawDefaultInspector();
    }
}
