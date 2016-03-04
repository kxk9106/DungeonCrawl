using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof (PlayerController))]
[RequireComponent (typeof (GunController))]

public class PlayerAgain : MonoBehaviour {
	//Sword swinging reference
	//http://www.code4all.nl/dokuwiki/unity_how_to_swing_a_sword
	
	public float moveSpeed = 5;
	
	Camera viewCamera;
	PlayerController controller;
	GunController gunController;
	
	public GameObject swordButton;
	public GameObject arrowButton;
	private float swingDuration = 0.2f;
	private float swingSpeed = 0.4f;
	
	private float swingTimer = 0f;
	//public bool swinging = false;
	private Vector3 startRot;
	
	private bool swordTime = true;
	private bool bowTime = false;
	public bool swi = false;
	
	private GameObject sword;
	private GameObject bow;
	public Animator ani;
	GameObject moneyText;
	Text mText;
	public int money = 0;
	
	Health2 hltScript;
	IncreaseHealth incHealthScript;
	public double playerHealth;
	
	/*void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}*/
	
	void  Start () {
		
		
		controller = GetComponent<PlayerController> ();
		gunController = GetComponent<GunController> ();
		
		moneyText = GameObject.FindGameObjectWithTag ("money");
		mText = moneyText.GetComponent<Text> ();
		viewCamera = Camera.main;
		//swordButton = GameObject.Find ("swordButton");
		startRot = transform.eulerAngles;
		sword = GameObject.FindGameObjectWithTag ("sword");
		bow = GameObject.FindGameObjectWithTag ("bow");
		
		sword.transform.localEulerAngles = new Vector3(0,90,50);
		sword.transform.position =  GameObject.FindGameObjectWithTag("hold").transform.position;
		sword.transform.SetParent(this.transform);
		
		playerHealth = 3.0;
		
		
		hltScript = FindObjectOfType (typeof(Health2)) as Health2;


		incHealthScript = FindObjectOfType (typeof(IncreaseHealth)) as IncreaseHealth;
		Debug.Log ("tempHealth" + incHealthScript.temp);
		playerHealth = incHealthScript.temp;
		hltScript.takeHeart();
		
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
		
		
		
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			swordTime = true;
			bowTime = false;
		}
		if (swordTime == true) {
			swordButton.GetComponent<Image>().color = Color.red;
			arrowButton.GetComponent<Image>().color = Color.white;
			sword.SetActive(true);
			bow.SetActive(false);
			if (Input.GetMouseButton(0)) {
				//swinging = true;
				//ani.SetTrigger("Swinging");
				ani.SetBool("isSwinging", true);
			}
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			bowTime = true;
			swordTime = false;
		}
		if (bowTime == true) {
			swordButton.GetComponent<Image>().color = Color.white;
			arrowButton.GetComponent<Image>().color = Color.red;
			sword.SetActive(false);
			bow.SetActive(true);
			if (Input.GetMouseButton (0)) {
				gunController.Shoot();
			}
		}
		
		if (Input.GetKeyDown (KeyCode.H)) {
			
			playerHealth = playerHealth - 0.5;
			hltScript.takeHeart();
			//Debug.Log (playerHealth);
		}
	}
	
	public bool StopSwinging()
	{
		swi = ani.GetBool ("isSwinging");
		return swi;
	}
	
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "coin") {
			Destroy(other.gameObject);
			money ++;
			mText.text = "Money: " + money;;
			Debug.Log("Getmoney");
		}
		Debug.Log ("colliding");
		
	}
}

