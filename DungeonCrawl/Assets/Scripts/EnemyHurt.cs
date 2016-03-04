using UnityEngine;
using System.Collections;

public class EnemyHurt : MonoBehaviour {
	GameObject play;
	Player plScript;
	public int health;

	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
		health = 3;
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
		health -= 1;
	}

	void amIalive(){
		if (health == 0 || health < 0) {
			Destroy(this.gameObject);
		}
	}


}