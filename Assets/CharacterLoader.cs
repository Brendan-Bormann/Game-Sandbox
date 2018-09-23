using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{

	public Character myChar;

	public void Initialize(Character mychar, Vector2 position)
	{
		myChar = mychar;
		gameObject.transform.position = position;
		gameObject.GetComponent<SpriteRenderer>().sprite = myChar.sprite;
	}
	
	void Update ()
	{
		
	}
}
