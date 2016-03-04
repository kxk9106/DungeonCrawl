using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoreStuff : MonoBehaviour {

	Player plScript;
	EnemyHurt enScript;
	public Text healthText;
	public Text weaponText;



	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
		enScript = FindObjectOfType (typeof(EnemyHurt)) as EnemyHurt;
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + plScript.playerHealth;
		//weaponText.text = "Weapon Power: " + enScript.enemyHealth;
	}
}
