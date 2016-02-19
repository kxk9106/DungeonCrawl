using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	

	public GameObject restartButton;
	
	
	void Start() {
	
	}
	
	void Update(){

	}

	public void menuButton()
	{
		Application.LoadLevel("Level1");
	}
}
