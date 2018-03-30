using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	public static GameController _instance;
	public float rewardTimer;
	public GameObject player;
	// public PlayerEnter isPlayerEnter;

	public GameObject[] preLevels;
	public GameObject currentLevels;
	public GameObject pastLevel;

	public GameObject topLevel;

	public float smoothDapping =10f;
	public float levelMovingDistance =0;
	public GameObject floor;

	private float rushLevelTimer =0.5f;
	public int addCount=0;
	// Use this for initialization
	private float timer=0f;

	private void Awake()
	{
		_instance=this;
	}
	void Start () 
	{
		currentLevels =GameObject.Instantiate(preLevels[0],Vector3.zero,Quaternion.identity);
		currentLevels.transform.position =Vector3.zero;
		pastLevel =currentLevels;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(PlayerEnter._instance.playerIsEnter)
		{
			addCount+=1;
			AddPreLevels();	
		}
	}
	private void AddPreLevel()
	{
		player.transform.position+=new Vector3(0,levelMovingDistance,0);
	}




	private void AddPreLevels()
	{
		player.transform.position+=new Vector3(0,levelMovingDistance,0);
		topLevel =pastLevel;
		pastLevel = currentLevels;
		currentLevels =GameObject.Instantiate(preLevels[GetNewLevelIndex()],Vector3.zero,Quaternion.identity);
	}
	int GetNewLevelIndex()
	{
		return Random.Range(0,preLevels.Length);
	}
}
