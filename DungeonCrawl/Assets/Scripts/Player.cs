using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof (PlayerController))]

public class Player : MonoBehaviour {
	//Sword swinging reference
	//http://www.code4all.nl/dokuwiki/unity_how_to_swing_a_sword
	
	public float moveSpeed = 5;
	
	Camera viewCamera;
	PlayerController controller;

	public GameObject swordButton;
	private float swingDuration = 0.2f;
	private float swingSpeed = 0.4f;
	
	private float swingTimer = 0f;
	private bool swinging = false;
	private Vector3 startRot;

	protected   void  Start () {
		controller = GetComponent<PlayerController> ();
		viewCamera = Camera.main;
		//swordButton = GameObject.Find ("swordButton");
		startRot = transform.eulerAngles;
	}

	
	// Update is called once per frame
	
	void Update () {

		//Movement input
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		controller.Move (moveVelocity);

		//Look input
		Ray ray = viewCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayDistance;
		
		if (groundPlane.Raycast(ray,out rayDistance)) {
			Vector3 point = ray.GetPoint(rayDistance);
			Debug.DrawLine(ray.origin,point,Color.red);
			//Debug.DrawRay(ray.origin,ray.direction * 100,Color.red);
			controller.LookAt(point);
		}

		//weapon input
		if (Input.GetMouseButton (0)) {
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			swinging = true;
		}
		
		if (swinging) {
			swingTimer += Time.deltaTime;
			
			if (swingTimer < (swingDuration / 2)) {
				transform.eulerAngles = Vector3.Lerp(startRot, new Vector3(0, 0, 1), swingSpeed);
			}
			
			if (swingTimer > (swingDuration / 2)) {
				transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, startRot, swingSpeed);
			}
			
			if (swingTimer > swingDuration) {
				swingTimer = 0f;
				swinging = false;
			}
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "sword") {
			//Destroy (other.gameObject);
			//Debug.Log ("Destroy");
			swordButton.GetComponent<Image>().color = Color.red;
			other.transform.localEulerAngles = new Vector3(0,90,50);
			other.transform.position =  GameObject.FindGameObjectWithTag("hold").transform.position;
			other.transform.SetParent(this.transform);
		} 
		
	}
}
