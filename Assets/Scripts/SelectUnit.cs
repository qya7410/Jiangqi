using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnit : MonoBehaviour {
    private Camera cam;
    public PlayerScore playerScore;
    public GameObject oneScoreEffect;
	// Use this for initialization
	void Start ()
    {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = new Ray();
            ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                if (hit.collider.tag =="Obslate")
                {
                   GameObject ins= Instantiate(oneScoreEffect,hit.point,Quaternion.identity);
                    Destroy(hit.collider.gameObject);
                    Destroy(ins,1f);
                    playerScore.currentPlayerScore+=1;

                }
                else
                {
                    Debug.DrawLine(ray.origin,hit.point , Color.red);
                }
            }
        }
      
	}
}
