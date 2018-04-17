using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BACKTOMAIN : MonoBehaviour {
	
	public void BackToMain () {
	SceneManager.LoadScene ("START MENU");
		Score.diamonds = 0;
		DeathsScript.deaths = 0;
}
	}
 