 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
	void Start () {
	}
	void OnTriggerEnter2D (Collider2D other){

		Destroy(gameObject);
	
		Score.diamonds++;
		Debug.Log (Score.diamonds);
	}
}
