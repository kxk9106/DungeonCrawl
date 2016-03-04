using UnityEngine;
using System.Collections;

public class wallDie2 : MonoBehaviour {
	GameObject play;
	PlayerAgain plScript;
	double wallHealth = 6;
	GameObject coin;
	WeaponPower wp;
	
	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(PlayerAgain)) as PlayerAgain;
		wp = FindObjectOfType (typeof(WeaponPower)) as WeaponPower;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "sword" && plScript.StopSwinging () == true) {
			wallHealth-= wp.enmHealth;
			Debug.Log (wallHealth);
		} else if (other.gameObject.tag == "projectile") {
			wallHealth-= wp.enmHealth;
			Destroy (other.gameObject);
			
		}
		if(wallHealth < 1)
		{
			coin = Instantiate(Resources.Load("coin")) as GameObject;
			coin.transform.position = this.transform.position;
			Vector3 temp = new Vector3(0,3,0);
			coin.transform.position +=temp;
			Destroy(this.gameObject);
			Debug.Log("Destroy called");
			
			
		}
		
		Debug.Log (other.gameObject.tag);
		
	}
}

