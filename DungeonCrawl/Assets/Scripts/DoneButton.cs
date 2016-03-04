using UnityEngine;
using System.Collections;

public class DoneButton : MonoBehaviour {
	GameObject player;
	Vector3 newPos;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		//newPos = new Vector3 (20f, .14f, 15f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void doneButton()
	{
		Destroy (player);
		Application.LoadLevel("Level2");

		//.transform.position = newPos;
		Time.timeScale = 1.0f;
	}
}
