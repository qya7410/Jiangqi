using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Floor : MonoBehaviour {


	public GameObject fiveScorePre;
	public bool isPalyerDead;
	public PlayerScore playerScore;
	public Button oneMoreTimeButton;
	private Text text;
	
	// Use this for initialization
	void Start () {
		isPalyerDead=false;
		text =oneMoreTimeButton.transform.Find("Text").GetComponent<Text>();
		text.enabled =false;
		oneMoreTimeButton.enabled=false;
		oneMoreTimeButton.image.enabled=false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPalyerDead&&oneMoreTimeButton.enabled==false)
		{
			oneMoreTimeButton.enabled=true;
			oneMoreTimeButton.image.enabled=true;
			text.enabled =true;
			Debug.Log(PalyerHighestScore.playerHighestSocre);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player")
		{
			isPalyerDead=true;
			if(playerScore.currentPlayerScore>PalyerHighestScore.playerHighestSocre)
			{
				PalyerHighestScore.playerHighestSocre=playerScore.currentPlayerScore;
			}
			Time.timeScale=0f;
			
			Application.LoadLevel(0);
		}
		if(other.tag=="Obslate")
		{
			GameObject ins =Instantiate(fiveScorePre,other.gameObject.transform.position,Quaternion.identity);
			Destroy(ins,1f);
			Destroy(other.gameObject);
			playerScore.currentPlayerScore+=5;
		}
	}

	public void Click()
	{
		
		Application.LoadLevel(0);
		Time.timeScale=1f;
	}
	// private void ReloadUI()
	// {

	// }
}
