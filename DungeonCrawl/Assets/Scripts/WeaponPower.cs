using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class WeaponPower : MonoBehaviour {

	EnemyHurt enScript;
	public Text weaponPow;
	public double enmHealth;

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
		
	}

	// Use this for initialization
	void Start () {
		enScript = FindObjectOfType (typeof(EnemyHurt)) as EnemyHurt;
		enmHealth = 6 - enScript.enemyHealth;
		weaponPow.text = "Weapon Power: " + enmHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void weaponStrong(){
		Debug.Log ("Ys");
		enScript.enemyHealth --;
		enmHealth = 6 - enScript.enemyHealth;
		weaponPow.text = "Weapon Power: " + enmHealth;
	}
}
