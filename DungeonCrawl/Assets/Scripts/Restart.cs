using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	public GameObject[] enem;

	public GameObject restartButton;
	
	
	void Start() {
		enem = GameObject.FindGameObjectsWithTag ("enemyB");

	}
	
	void Update(){

	}

	public void menuButton()
	{
		for (int i = 0; i < enem.Length; i++) {
			Destroy(enem[i]);
		}
		Application.LoadLevel("Level1");
	}
}
