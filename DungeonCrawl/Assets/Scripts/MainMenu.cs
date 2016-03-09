using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameObject[] enem;
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
		Application.LoadLevel("StartScreen");
	}
}
