using UnityEngine;
using System.Collections;

public class wallDie : MonoBehaviour {
    GameManager InstanceOfGameManager;
	GameObject play;
	Player plScript;
	int wallHealth = 3;
	GameObject coin;
    char[,] Map = new char[8, 18];
	
	// Use this for initialization
	void Start () {
		plScript = FindObjectOfType (typeof(Player)) as Player;
        InstanceOfGameManager = GameObject.FindGameObjectsWithTag("MainGo")[0].GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "sword" && plScript.StopSwinging () == true) {
			wallHealth--;
			Debug.Log (wallHealth);
		} else if (other.gameObject.tag == "projectile") {
			wallHealth--;
			Destroy (other.gameObject);

		}
			if(wallHealth < 1)
			{
				coin = Instantiate(Resources.Load("coin")) as GameObject;
				coin.transform.position = this.transform.position;
				Vector3 temp = new Vector3(0,3,0);
				coin.transform.position +=temp;
				Destroy(this.gameObject);

                //InstanceOfGameManager = GameObject.FindGameObjectsWithTag("MainGo")[0].GetComponent<GameManager>();
                //set map position to empty
                InstanceOfGameManager.editMap((int)this.transform.position.x / 5, (int)this.transform.position.z / 5, '0'); //Map[(int)this.transform.position.x / 5, (int)this.transform.position.z / 5] = '0';
				//Debug.Log("Destroy called");


			}

		//Debug.Log (other.gameObject.tag);
		
	}
}
