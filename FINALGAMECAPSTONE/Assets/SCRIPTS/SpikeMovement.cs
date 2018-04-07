using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour {

	public float speed = .1f;
	public GameObject character;
	// Use this for initialization

	private double yPositionMax;
	void Start () {
		yPositionMax = transform.position.y + .2;
	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x <= character.transform.position.x) {
			if (yPositionMax >= transform.position.y) {
				transform.Translate (0, speed, 0);
			}
		}

	}
}
