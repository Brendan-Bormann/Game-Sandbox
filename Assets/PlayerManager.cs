using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
	public static PlayerManager Instance;
	public GameObject Player;
	public GameObject PlayerPrefab;
	public GameObject spawn;

	// Use this for initialization
	void Start ()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(this);
		}

		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Player == null && !once)
		{
			if (GameObject.Find("Spawn") != null)
			{
				spawn = GameObject.Find("Spawn");
				Player = Instantiate(PlayerPrefab, spawn.transform.position, Quaternion.identity);
			}
		}

		if (Input.GetKeyDown(KeyCode.M))
		{
			SceneManager.LoadScene("Battle");
		}

		if (Input.GetKeyDown(KeyCode.N))
		{
			SceneManager.LoadScene("Scene1");
		}

		if (GameObject.Find("StageLoader") && !once)
		{
			once = true;
			StartCombat(GameObject.Find("StageLoader").GetComponent<StageLoader>());
		}
	}

	public bool once = false;

	[SerializeField] private Character PlayerCharacter;
	[SerializeField] private Character EnemyCharacter;

	public void StartCombat(StageLoader stageloader)
	{
		stageloader.init(PlayerCharacter, EnemyCharacter);
	}
}
