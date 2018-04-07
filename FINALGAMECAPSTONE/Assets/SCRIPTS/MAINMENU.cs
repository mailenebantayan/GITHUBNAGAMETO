﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MAINMENU : MonoBehaviour {

	public void Play ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void Instructions ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
	}

	public void Quit ()
	{
		Debug.Log ("QUIT!");
		Application.Quit ();
	}
}
