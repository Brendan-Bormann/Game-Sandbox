using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	public string newScene;

	// Use this for initialization
	void Start () {
		
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Entered Trigger/");

		SceneManager.LoadScene(newScene);
	}
}
