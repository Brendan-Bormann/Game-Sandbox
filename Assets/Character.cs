using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Character", fileName="NewCharacter")]
public class Character : ScriptableObject
{
	public int currentHealth = 1;
	public int maxHealth = 1;
	public Sprite sprite;

}
