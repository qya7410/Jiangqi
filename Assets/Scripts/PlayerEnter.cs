using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnter : MonoBehaviour {

	public static PlayerEnter _instance;
	public bool playerIsEnter=false;


	private void Awake()
	{
		_instance=this;
	}
	 private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{
			Debug.Log("1111111111111");
			playerIsEnter =true;
		}
		else
		{
			playerIsEnter =false;
		}
	}
	 private void OnTriggerEixt(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{
			Debug.Log("1111111111111");
			if(playerIsEnter ==true)
			{
				playerIsEnter =false;
			}
		}
	}
}
