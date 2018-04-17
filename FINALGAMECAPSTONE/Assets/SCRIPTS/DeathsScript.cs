using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathsScript : MonoBehaviour {
	public static int deaths = 0;
	public GUISkin LabelSkin;
	void Start () {
	}
	void OnGUI(){
		GUI.skin = LabelSkin;
		GUI.color = Color.white;
		GUI.Label (new Rect (10, 60, 300, 100), "Deaths:" + DeathsScript.deaths);
	}	
}
