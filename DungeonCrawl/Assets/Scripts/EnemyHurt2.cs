using UnityEngine;
using System.Collections;

public class EnemyHurt2 : MonoBehaviour {
	GameObject play;
	PlayerAgain plScript;
	WeaponPower wp;
	public double enemyHealth;
	
	
	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(PlayerAgain)) as PlayerAgain;
		wp = FindObjectOfType (typeof(WeaponPower)) as WeaponPower;
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

		} 
		
		if (other.gameObject.tag == "projectile") {
			takeDamage();
			Destroy (other.gameObject);
			//Destroy(this.gameObject);
		
		} 
		Debug.Log (other.gameObject.tag);
		
	}
	
	void takeDamage(){
		Debug.Log("sjifwejf" + wp.enmHealth);
		enemyHealth -= wp.enmHealth;
	}
	
	void amIalive(){
		if (enemyHealth == 0 || enemyHealth < 0) {
			Destroy(this.gameObject);
		}
	}
	
	
}