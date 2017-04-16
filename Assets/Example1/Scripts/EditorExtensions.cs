using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorExtensions  
{
	[MenuItem("Assets/Create/MyScriptableObj")]
	public static void CreateMyLightObj()
	{
		MyScriptableObj asset = ScriptableObject.CreateInstance<MyScriptableObj> ();
		AssetDatabase.CreateAsset(asset, "Assets/ScriptableObj.asset");
		AssetDatabase.SaveAssets();
		EditorUtility.FocusProjectWindow();
		Selection.activeObject=asset;
	}
}
