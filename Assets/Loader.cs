using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{

	[SerializeField] private GameObject playerManager;

	void Start ()
	{
		if (PlayerManager.Instance == null)
		{
			Instantiate(playerManager);
		}

		Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
