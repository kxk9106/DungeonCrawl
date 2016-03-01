using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    
    
    GameManager InstanceOfGameManager;

	// Use this for initialization
	void Start () {

        
	
	}

    void Awake()
    {
        InstanceOfGameManager = GameObject.FindGameObjectsWithTag("MainGo")[0].GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
