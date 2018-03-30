using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

	public int currentPlayerScore=0;
	// Use this for initialization
	public Text text;
	public Text text2;
	void Awake () {
		// _instance=this;
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text ="本场得分："+ currentPlayerScore.ToString()+"分";
		text2.text ="最佳成绩"+PalyerHighestScore.playerHighestSocre.ToString()+"分";
	}
}
