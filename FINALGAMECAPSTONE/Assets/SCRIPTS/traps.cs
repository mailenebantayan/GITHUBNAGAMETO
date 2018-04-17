using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traps : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		DeathsScript.deaths++;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
