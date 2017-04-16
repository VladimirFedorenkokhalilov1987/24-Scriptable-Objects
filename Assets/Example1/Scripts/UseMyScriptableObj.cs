using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseMyScriptableObj : MonoBehaviour
{
	[SerializeField] 
	private MyScriptableObj myScriptableObj; 

	private List<Light> myLights; 

	void Start () 
	{
		myLights = new List<Light>();

		foreach (var spawn in myScriptableObj.SpawnPoints)
		{
			var myLight = new GameObject ("Light");
			myLight.AddComponent<Light> ();
			myLight.transform.position = spawn;
			myLight.GetComponent<Light>().enabled = false;

			if (myScriptableObj.ColorIsRandom)
			{ 
			myLight.GetComponent<Light>().color = new Color (Random.Range (0f, 1f),
															Random.Range (0f, 1f),
															Random.Range (0f, 1f));
			}
			else
			{
				myLight.GetComponent<Light>().color = myScriptableObj.MyColor;
			}
			myLights.Add (myLight.GetComponent<Light>());
		}
	}

	void Update () 
	{ 
		if (Input.GetButtonDown ("Fire1")) 
		{ 
			foreach (var item in myLights) 
			{
				item.enabled = !item.enabled; 
			}
		}

		if (Input.GetButton ("Fire2"))
		{
			UpdateLights ();
		}
	}

	void UpdateLights ()
	{
		foreach (var item in myLights)
		{
			item.GetComponent<Light>().color = new Color (Random.Range (0f, 1f),
				Random.Range (0f, 1f),
				Random.Range (0f, 1f));
			item.GetComponent<Light> ().intensity = Random.Range (1f, 3f);
			item.GetComponent<Light> ().range = Random.Range (10f, 15f);
		}
	}
}
