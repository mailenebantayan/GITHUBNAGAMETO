using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPrevious : MonoBehaviour {

	public GameObject instructions1;
	public GameObject instructions2;
	public GameObject instructions3;
	public GameObject instructions4;

	// Use this for initialization
	void Start () {
	}

	public void BackToMain(){
		SceneManager.LoadScene ("START MENU");
	}

	public void NextPanel (){
		
		instructions1.SetActive (false);
		instructions2.SetActive (true);
	}



	public void NextPanel1 (){

		instructions2.SetActive (false);
		instructions3.SetActive (true);
	}

	public void PreviousPanel (){
		instructions1.SetActive (true);
		instructions2.SetActive (false);
	}
	public void NextPanel2 (){

		instructions3.SetActive (false);
		instructions4.SetActive (true);
	}

	public void PreviousPanel1 (){
		instructions2.SetActive (true);
		instructions3.SetActive (false);
	}

	public void PreviousPanel2 (){
		instructions3.SetActive (true);
		instructions4.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	}
}
