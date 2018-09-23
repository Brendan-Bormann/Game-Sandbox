using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLoader : MonoBehaviour {

	[SerializeField] private PlayerManager playerManager;

	[SerializeField] private GameObject CharacterLoader;

	private Character Player;
	private Character Enemy;


	[SerializeField] private GameObject playerSpawn;
	[SerializeField] private GameObject enemySpawn;

	public void init(Character newPlayer, Character newEnemy)
	{
		Player = newPlayer;
		Enemy = newEnemy;

		var PlayerInstance = Instantiate(CharacterLoader);
		PlayerInstance.GetComponent<CharacterLoader>().Initialize(Player, playerSpawn.transform.position);

		var EnemyInstance = Instantiate(CharacterLoader);
		EnemyInstance.GetComponent<CharacterLoader>().Initialize(Enemy, enemySpawn.transform.position);
	}

	void Start ()
	{
		playerManager = PlayerManager.Instance;
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


}
