using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChild : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.childCount<=0)
		{
			Destroy(this.gameObject);
		}else
		{
			if(PlayerEnter._instance.playerIsEnter)
			{
					for(int i=0;i<transform.childCount;i++)
				{
					transform.GetChild(i).GetComponent<Rigidbody>().isKinematic=true;
				}
				transform.position+=new Vector3(0,GameController._instance.levelMovingDistance,0);
			}
			else
			{
				for(int i=0;i<transform.childCount;i++)
				{
					transform.GetChild(i).GetComponent<Rigidbody>().isKinematic=false;
				}
			}
		}
	}
}
