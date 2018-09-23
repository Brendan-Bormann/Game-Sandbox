using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector2(gameObject.transform.position.x + Input.GetAxis("Horizontal") * speed, gameObject.transform.position.y + Input.GetAxis("Vertical") * speed);
	}
}
