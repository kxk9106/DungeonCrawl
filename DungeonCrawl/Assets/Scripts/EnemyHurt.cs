﻿using UnityEngine;
using System.Collections;

public class EnemyHurt : MonoBehaviour {
	GameObject play;
	Player plScript;
	public int enemyHealth;
	

	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
		enemyHealth = 5;
		//Debug.Log (plScript.swinging);
	}

	// Update is called once per frame
	void Update () {
		amIalive ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "sword" && plScript.StopSwinging() == true) {
			takeDamage ();
			//Destroy(this.gameObject);
			Debug.Log("Destroy called");
		} 

		if (other.gameObject.tag == "projectile") {
			takeDamage();
			Destroy (other.gameObject);
			//Destroy(this.gameObject);
			Debug.Log("Destroy called");
		} 
		Debug.Log (other.gameObject.tag);

	}

	void takeDamage(){
		enemyHealth -= 1;
	}

	void amIalive(){
		if (enemyHealth == 0 || enemyHealth < 0) {
			Destroy(this.gameObject);
		}
	}


}