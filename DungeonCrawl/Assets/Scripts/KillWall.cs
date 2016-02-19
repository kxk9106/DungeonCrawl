using UnityEngine;
using System.Collections;

public class KillWall : MonoBehaviour {

	//public GameObject player;

	// Use this for initialization
	void Start () {
	//Collider col = player.GetComponent<Collider>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			Destroy(other.gameObject);
		}
	}
}
