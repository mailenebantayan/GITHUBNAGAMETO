using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
		public Transform diePanel;
		public Transform left, right, jump;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				diePanel.gameObject.SetActive (true);
				left.gameObject.SetActive (false);
				right.gameObject.SetActive (false);
				jump.gameObject.SetActive (false);
                //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }

		public void tryAgain()
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		}
    }
}