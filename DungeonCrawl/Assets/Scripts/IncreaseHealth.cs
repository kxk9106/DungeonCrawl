using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IncreaseHealth : MonoBehaviour {
	
	//PlayerAgain plAScript;
	Player plScript;
	public Text plTempHealth;
	public double temp;

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);

	}

	// Use this for initialization
	void Start () {
		//plAScript = FindObjectOfType (typeof(PlayerAgain)) as PlayerAgain;
		plScript = FindObjectOfType (typeof(Player)) as Player;
		plTempHealth.text = "Health: " + plScript.playerHealth;
		temp = plScript.playerHealth;
	}

	public void changeHealth(){
		plScript.playerHealth++;
		plTempHealth.text = "Health: " + plScript.playerHealth;
		if(plTempHealth.text.Contains("3")){
			//plAScript.playerHealth = 3;
			temp = 3;
		}
		else if(plTempHealth.text.Contains("2.5")){
			//plAScript.playerHealth = 2.5;
			temp = 2.5;
		}
		else if(plTempHealth.text.Contains("2")){
			//plAScript.playerHealth = 2.0;
			temp = 2.0;
		}
		else if(plTempHealth.text.Contains("1.5")){
			//plAScript.playerHealth = 1.5;
			temp = 1.5;
		}
		else if(plTempHealth.text.Contains("1")){
			//plAScript.playerHealth = 1.0;
			temp = 1.0;
		}
		else if(plTempHealth.text.Contains(".5")){
			//plAScript.playerHealth = .5;
			temp = .5;
		}
		else if(plTempHealth.text.Contains("0")){
			//plAScript.playerHealth = 0;
			temp = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {

	}
}
