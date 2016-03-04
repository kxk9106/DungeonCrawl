using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour {
    
    
    GameManager InstanceOfGameManager;
    GameObject InstanceOfPlayer;
    bool seekPlayer = false; //signifies the player is close enough to target directly
    bool pathActive = false; //signifies if a path is already being followed
    int currentPathTarget = 0; // used to keep track of which point is next in line
    public float EnemySpeed; //speed of the enemies movement (set in prefab window)
    public int HostilityDistance; //from how far away (path steps)will they actively seek you
    List<int[]> directions;
    int[] assumedPosition = new int[2];

	// Use this for initialization
	void Start () {
        
        
	
	}
    
    void Awake()
    {
        InstanceOfGameManager = GameObject.FindGameObjectsWithTag("MainGo")[0].GetComponent<GameManager>();
        InstanceOfPlayer = GameObject.FindGameObjectsWithTag("Player")[0];
    }
	
	// Update is called once per frame
	void Update () {
        if (InstanceOfPlayer.gameObject != null)
        {
            
            //Debug.Log("Player position: " +(int)InstanceOfPlayer.transform.position.z / 5 + "," + (int)InstanceOfPlayer.transform.position.x / 5 + " Enemy Position: " + (int)this.gameObject.transform.position.z / 5 + "," + (int)this.gameObject.transform.position.x / 5);
            if (((int)InstanceOfPlayer.transform.position.z / 5 == (int)this.gameObject.transform.position.z / 5) && ((int)InstanceOfPlayer.transform.position.x / 5 == (int)this.gameObject.transform.position.x / 5))
            {
                //Debug.Log("Im close!");
                seekPlayer = true;
            }
            else
            {
                //Debug.Log("P Z,X: " + (int)InstanceOfPlayer.transform.position.z / 5 + "," + (int)InstanceOfPlayer.transform.position.x / 5);
                //Debug.Log("E Z,X: " + (int)this.gameObject.transform.position.z / 5 + "," + (int)this.gameObject.transform.position.x / 5);
                seekPlayer = false;
            }
        }

        if (seekPlayer)
        {
            this.gameObject.transform.LookAt(new Vector3(InstanceOfPlayer.transform.position.x, 1, InstanceOfPlayer.transform.position.z));
            Vector3 forwardMovement = this.transform.forward;
            forwardMovement.Scale(new Vector3(EnemySpeed, EnemySpeed, EnemySpeed));
            this.transform.position += forwardMovement;
        }
        else
        {
            if (pathActive) //follow current path
            {
                if ((assumedPosition[0] == (int)InstanceOfPlayer.transform.position.x / 5) && (assumedPosition[1] == (int)InstanceOfPlayer.transform.position.z / 5))
                {
                    if ((((int)this.transform.position.x) / 5 != ((int)InstanceOfPlayer.transform.position.x)  / 5) || ((int)this.transform.position.z / 5 != (int)InstanceOfPlayer.transform.position.z / 5))
                    {
                        //Debug.Log(directions.ToArray().Length);
                        foreach (int[] elem in directions)
                        {
                            //Debug.Log("List: " + elem[0] + "," + elem[1]);
                        }
                        
                        this.gameObject.transform.LookAt(new Vector3((directions[currentPathTarget][0] * 5) + 2.5f, 1, (directions[currentPathTarget][1] * 5) + 2.5f));
                        Vector3 forwardMovement = this.transform.forward;
                        forwardMovement.Scale(new Vector3(EnemySpeed, EnemySpeed, EnemySpeed));
                        this.transform.position += forwardMovement;
                    }
                    else
                    {
                        //Debug.Log("before: " + currentPathTarget);
                        currentPathTarget++;
                        //Debug.Log("before: " + currentPathTarget);
                    }
                }
                else
                {
                    Debug.Log("Path Deactive");
                    pathActive = false;
                }
            }
            else //generate new path
            {

                directions = InstanceOfGameManager.GetAStarList(this.gameObject);
                pathActive = true;
                currentPathTarget = directions.Count - 1;
                assumedPosition[0] = (int)InstanceOfPlayer.transform.position.x / 5;
                assumedPosition[1] = (int)InstanceOfPlayer.transform.position.z / 5;
                //Debug.Log(directions.Count);

            }
        }
	
	}
}
