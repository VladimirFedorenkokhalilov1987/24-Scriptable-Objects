using UnityEngine;
using System.Collections;

[SerializeField]
public class MyScriptableObj : ScriptableObject
{
	public string ObjName = "new scriptable obj";
	public bool ColorIsRandom = false;
	public Color MyColor = Color.white;
	public Vector3[] SpawnPoints;
}
