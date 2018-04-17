using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public static int diamonds = 0;
	public GUISkin LabelSkin;
	void Start () {
	}
	void OnGUI(){
		GUI.skin = LabelSkin;
		GUI.color = Color.white;
		GUI.Label(new Rect(10,40,300,100), "Score: " +Score.diamonds);
	}
}
