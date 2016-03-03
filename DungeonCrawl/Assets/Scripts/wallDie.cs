using UnityEngine;
using System.Collections;

public class wallDie : MonoBehaviour {
	GameObject play;
	Player plScript;
	int wallHealth = 3;
	
	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "sword" && plScript.StopSwinging() == true) {
			wallHealth --;
			Debug.Log (wallHealth);
			if(wallHealth < 1)
			{
				Destroy(this.gameObject);
				Debug.Log("Destroy called");

			}

		} 
		Debug.Log (other.gameObject.tag);
		
	}
}
