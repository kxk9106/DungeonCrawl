using UnityEngine;
using System.Collections;

public class Telepad : MonoBehaviour {

	public GameObject cam;

	// Use this for initialization
	void Start () {
		cam = GameObject.FindGameObjectWithTag ("MainCamera");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel ("Store");
			cam.GetComponent<CameraController> ().enabled = false;
			Time.timeScale = 0;
		}
	}
}
