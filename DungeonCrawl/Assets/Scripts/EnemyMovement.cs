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
    public int pursueDistance; //how far will the monsters sursue you from
    List<int[]> directions;
    int[] assumedPosition = new int[2];
    //Stack<int[]> directionStack;
    

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
                seekPlayer = true;
            }
            else
            {
                //Debug.Log("P Z,X: " + (int)InstanceOfPlayer.transform.position.z / 5 + "," + (int)InstanceOfPlayer.transform.position.x / 5);
                //Debug.Log("E Z,X: " + (int)this.gameObject.transform.position.z / 5 + "," + (int)this.gameObject.transform.position.x / 5);
                seekPlayer = false;
            }
        }

        if (seekPlayer && (InstanceOfPlayer.gameObject != null))
        {
            this.gameObject.transform.LookAt(new Vector3(InstanceOfPlayer.transform.position.x, 1, InstanceOfPlayer.transform.position.z));
            Vector3 forwardMovement = this.transform.forward;
            forwardMovement.Scale(new Vector3(EnemySpeed, EnemySpeed, EnemySpeed));
            this.transform.position += forwardMovement;
        }
        else if(InstanceOfPlayer.gameObject != null)
        {
            if (pathActive) //follow current path
            {
                //if the path still ends where the player is
                if ((assumedPosition[0] == (int)InstanceOfPlayer.transform.position.x / 5) && (assumedPosition[1] == (int)InstanceOfPlayer.transform.position.z / 5))
                {
                    //if enemy is not at current destination
                    if (/*((directions[currentPathTarget][0] < directions.ToArray().GetLength(0)) && (directions[currentPathTarget][1] < directions.ToArray().GetLength(1))) && */ (((int)this.transform.position.x) / 5 != directions[currentPathTarget][0]) || ((int)this.transform.position.z / 5 != directions[currentPathTarget][1]))//((((int)this.transform.position.x) / 5 != ((int)InstanceOfPlayer.transform.position.x) / 5) || ((int)this.transform.position.z / 5 != (int)InstanceOfPlayer.transform.position.z / 5))
                    {
                        if (directions.Count < pursueDistance)
                        {
                            this.gameObject.transform.LookAt(new Vector3((directions[currentPathTarget][0] * 5) + 2.5f, 2, (directions[currentPathTarget][1] * 5) + 2.5f));
                            Vector3 forwardMovement = this.transform.forward;
                            forwardMovement.Scale(new Vector3(EnemySpeed, EnemySpeed, EnemySpeed));
                            this.transform.position += forwardMovement;
                        }
                    }
                    else //iterate to next point in path 
                    {
                        currentPathTarget++;
                    }
                }
                else //the path is flagged to be re-calculated
                {
                    pathActive = false;
                }
            }
            else //generate new path
            {
                
                

                directions = InstanceOfGameManager.GetAStarList(this.gameObject);
                pathActive = true;
                currentPathTarget = 1;// = directions.Count - 1;
                assumedPosition[0] = (int)InstanceOfPlayer.transform.position.x / 5;
                assumedPosition[1] = (int)InstanceOfPlayer.transform.position.z / 5;

                /* //show path
                foreach (int[] elem in directions)
                {
                    //elem[0]--;
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Vector3 pos = new Vector3((elem[0] * 5) + 2.5f, 6, (elem[1] * 5) + 2.5f);
                    Quaternion rot = Quaternion.LookRotation(new Vector3(0f, 0f, 0f));
                    GameObject.Instantiate(cube, pos, rot);

                    //directionStack.Pop(elem);
                }
                 */ 
            }
        }
	
	}
}
