﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health2 : MonoBehaviour {
	
	public Image heart1;
	public Image heart2;
	public Image heart3;
	PlayerAgain plScript;



	
	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(PlayerAgain)) as PlayerAgain;
		//heart1.fillAmount = 1;
		//heart2.fillAmount = 1;
		//heart3.fillAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//reduces health
		/*if (Input.GetKeyDown (KeyCode.H)) {
			if(heart3.fillAmount == 1){
				heart3.fillAmount = .5f;
			}
			else if(heart3.fillAmount == .5f){
				heart3.fillAmount = 0f;
			}
			else if(heart2.fillAmount == 1 && heart3.fillAmount == 0f){
				heart2.fillAmount = .5f;
			}
			else if(heart2.fillAmount == .5f && heart3.fillAmount == 0f){
				heart2.fillAmount = 0f;
			}
			else if(heart1.fillAmount == 1 && heart2.fillAmount == 0f){
				heart1.fillAmount = .5f;
			}
			else if(heart1.fillAmount == .5f && heart2.fillAmount == 0f){
				heart1.fillAmount = 0f;
				Application.LoadLevel("decisionScreen");
			}
		}*/
		
	}
	public void takeHeart()
	{
		Debug.Log ("Health " + plScript.playerHealth);
		if (plScript.playerHealth == 2.5) {
			heart3.fillAmount = .5f;
			heart2.fillAmount = 1.0f;
			heart1.fillAmount = 1.0f;
		}
		else if (plScript.playerHealth == 2) {
			heart3.fillAmount = 0f;
			heart2.fillAmount = 1.0f;
			heart1.fillAmount = 1.0f;
		}
		else if (plScript.playerHealth == 1.5) {
			heart3.fillAmount = 0f;
			heart2.fillAmount = .5f;
			heart1.fillAmount = 1.0f;
		}
		else if (plScript.playerHealth == 1.0) {
			heart3.fillAmount = 0f;
			heart2.fillAmount = 0f;
			heart1.fillAmount = 1.0f;
		}
		else if (plScript.playerHealth == .5) {
			heart3.fillAmount = 0f;
			heart2.fillAmount = 0f;
			heart1.fillAmount = .5f;
		}
		else if (plScript.playerHealth == 0) {
			heart3.fillAmount = 0f;
			heart2.fillAmount = 0f;
			heart1.fillAmount = 0f;
		}
	}
}
