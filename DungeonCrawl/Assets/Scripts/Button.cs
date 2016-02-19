using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {


	public GameObject startButton;


	void Start() {
		Debug.Log ("sifjweifjewifjewfj");
		//startButton.GetComponent<Image>().color = Color.red;
	}

	void Update(){
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("Level1");
		}
	}

	void OnMouseExit() {
		startButton.GetComponent<Image>().color = Color.white;
		
	}
}
