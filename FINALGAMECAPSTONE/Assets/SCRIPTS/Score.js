﻿#pragma strict


var diamonds : int = 0;
var LabelSkin : GUISkin;
function Start () {
	
}

function Update () {
	
}

function OnGUI(){
GUI.skin = LabelSkin;
GUI.color = Color.white;
GUI.Label(new Rect(10,5,300,100), "Score: " +diamonds);
}
