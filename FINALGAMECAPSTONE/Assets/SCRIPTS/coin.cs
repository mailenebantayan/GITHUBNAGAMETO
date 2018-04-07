using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
	private int score = Score;

	void Start () {

		score = GameObject.FindGameObjectWithTag("Player").GetComponent(Score);
	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.tag == "Player"){
			score.diamonds += 1;
			Destroy(gameObject);
		}
	}
}
