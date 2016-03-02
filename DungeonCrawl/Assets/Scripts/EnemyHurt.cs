using UnityEngine;
using System.Collections;

public class EnemyHurt : MonoBehaviour {
	GameObject play;
	Player plScript;

	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
		//Debug.Log (plScript.swinging);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "sword" && plScript.StopSwinging() == true) {
			Destroy(this.gameObject);
			Debug.Log("Destroy called");
		} 
		Debug.Log (other.gameObject.tag);
		
	}
}
