using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoreStuff : MonoBehaviour {

	Player plScript;
	EnemyHurt enScript;
	WeaponPower wpScript;
	public Text healthText;
	public Text weaponText;
	public Text moneyText;

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}


	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
		enScript = FindObjectOfType (typeof(EnemyHurt)) as EnemyHurt;
		wpScript = FindObjectOfType (typeof(WeaponPower)) as WeaponPower;

	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text = "Money: " + plScript.money;
		healthText.text = "Health: " + plScript.playerHealth;
		weaponText.text = "Weapon: " + wpScript.enmHealth;
		//weaponText.text = "Weapon Power: " + enScript.enemyHealth;
	}
}
