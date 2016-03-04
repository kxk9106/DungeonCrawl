using UnityEngine;
using System.Collections;

public class DoneButton : MonoBehaviour {
	GameObject player;
	Vector3 newPos;
	public GameObject[] enem;


	// Use this for initialization
	void Start () {
		enem = GameObject.FindGameObjectsWithTag ("enemyB");
		player = GameObject.FindGameObjectWithTag ("Player");
		//newPos = new Vector3 (20f, .14f, 15f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void doneButton()
	{
		for (int i = 0; i < enem.Length; i++) {
			Destroy(enem[i]);
		}

		Destroy (player);
		Application.LoadLevel("Level2");

		//.transform.position = newPos;
		Time.timeScale = 1.0f;
	}
}
