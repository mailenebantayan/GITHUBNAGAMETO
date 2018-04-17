using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGrounds : MonoBehaviour {
	public float speed = 5f;
	public GameObject character;
	private bool isPass;
	// Use this for initialization
	void Start () {
		isPass = false;
	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x <= character.transform.position.x)
			isPass = true;

		if(isPass)
			transform.Translate (0, -speed * Time.deltaTime, 0);

	}
}
