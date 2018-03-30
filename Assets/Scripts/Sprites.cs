using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour {

    private Rigidbody rig;
	// Use this for initialization
	void Start () {
		rig =GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	// public void UseGravity()
	// {
	// 	rig.useGravity =true;
	// }
	// private void OnCollisionEnter(Collision other)
	// {
	// 	if(!rig.useGravity)
	// 	{
	// 		rig.useGravity =true;
	// 	}
	// }
}
