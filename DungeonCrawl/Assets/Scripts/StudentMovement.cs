using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class StudentMovement : MonoBehaviour {

	//setup
	public int[] target;
	public int[] start;

	public GameObject Point;
	public  GameObject[] DirCube;



	Tile tileTarget;
	
	List<int[]> Path = new List<int[]>(); //Holds the final path built from a series of points

	Dictionary<int[] , Tile> OpenList = new Dictionary<int[] , Tile>(new MyEqualityComparer());
	Dictionary<int[] , Tile> ClosedList = new Dictionary<int[] , Tile>(new MyEqualityComparer());


	
	GameManager InstanceOfGameManager;
	


	void Awake ()
	{
		//InstanceOfGameManager = GameObject.Find("MainGO").GetComponent<GameManager>();
		//InstanceOfGameManager = GameObject.FindGameObjectsWithTag("Main").GetComponent<GameManager>(); //This methode of selecting the game object was used previously but seems to be deprecated now
		InstanceOfGameManager = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<GameManager>();
	}

	// Use this for initialization
	void Start () {
		start = new int[2];
		start [0] = (int)transform.position.x;
		start [1] = (int)transform.position.z;

		
		
		target = new int[2]; //stores the target position
		target = Randomlocation ();

		CalculateAStar ();



	}
	
	// Update is called once per frame
	void Update () {

	
	}



    /// <summary>
    /// Calculates an AStar path to a target
    /// </summary>
	void CalculateAStar()
	{


		Tile firstNode = new Tile (start, target, start, 0);
		OpenList.Add (firstNode.coordinates, firstNode); //place root node on the open list

		//int cycles = 0;
		while (!(ClosedList.ContainsKey(target))) //function stops when the path leads to the target
		{
			//cycles++;


			int low = 74612638; //holds the current path efficiency recordto be checked against (starts out with a massive place holder record)
			int[] lowKey = new int[2]; //holds the location of the tile in the open list that currently has the cheapest path
			foreach (KeyValuePair<int[], Tile> elem in OpenList) //search for lowest cost tile
			{
				Tile temp = elem.Value;
				if (temp.G < low)
				{
					low = temp.G;
					Array.Copy(elem.Key, lowKey, 2);
				}
			}



			Tile temp55;
			OpenList.TryGetValue(lowKey, out temp55);
			ClosedList.Add(lowKey,temp55);
			OpenList.Remove(lowKey);


			Tile Current;// = new Tile(new int[2], new int[2], new int[2], 0);


			bool isthere = false;
			isthere = ClosedList.TryGetValue(lowKey, out Current);



            CheckSurroundings(Current.coordinates, Current); //check surrounding tiles

            
		}

		
		

        

		Tile Sorter;
		bool exists = ClosedList.TryGetValue (target, out Sorter); //Since the completed list will always end on the target, the program searches for the path there and iterates back through the doubley linked list of tiles till it reaches the head.
        if (exists)
        {
            while (/*(Sorter.Previous != null) && */(Sorter.Previous[0] != Sorter.coordinates[0]) || (Sorter.Previous[1] != Sorter.coordinates[1])) //The path head points to itself as the previous node, so the program checks for this to determine if its at the end
            {
                if (true)
                {
                    Vector3 pos = new Vector3(Sorter.coordinates[0], 0f, Sorter.coordinates[1]);

                    Quaternion rot = Quaternion.LookRotation(new Vector3(Sorter.Previous[0], 0f, Sorter.Previous[1]));
                    GameObject.Instantiate(Point, pos, rot);
                }
                


                Path.Add((int[])Sorter.coordinates.Clone()); //adds the coordinates to the path (note: the resulting path is backwards at this stage)
                ClosedList.TryGetValue(new int[] { Sorter.Previous[0], Sorter.Previous[1] }, out Sorter);
            }
            Path.Reverse(); //reverses the list so that slot 0 is the path head and the last item is the destination
        }

			

		//for (int i = 0; i < Path.Count; i++)
		//{
		//	Debug.Log("The path: " + Path[i][0] + "," + Path[i][1]); //how to iterate through path
		//}


		//Debug.Log ("path count: " + Path.Count);



		
	}
	
	
	
	

	/// <summary>
	/// This method polls a random room from the list to be used as a
	/// classroom assignment.
	/// </summary>
	int[] Randomlocation ()
	{
		int[] m_randomRoom = new int[2];
		int randomRoom = UnityEngine.Random.Range (0, 12);
		m_randomRoom [0] = InstanceOfGameManager.locations [randomRoom, 0];
		m_randomRoom [1] = InstanceOfGameManager.locations [randomRoom, 1];
		
		return(m_randomRoom);
	}


    /// <summary>
    /// merged position checker
    /// </summary>
    void CheckSurroundings(int[] centerPosition, Tile m_current)
	{

        int[] posToCheck = {0,0};
        Array.Copy(centerPosition, posToCheck, 2);
        

        
		bool exists; //keeps track of if the tile exists in the dictionary yet
        Tile checkingTile; //the tile object to focus on
		
        
        for (int i = 0; i < 4; i++)
        {
            Array.Copy(centerPosition, posToCheck, 2); //reset for next section
            
            /*Note the switch cases 0 - 3 checks the adjacent cells from the top in clockwise
             order, cases 4 - 7 cover the corner cells in clock wise order from the top left cell,
             Diagram:
                    {4 0 5,
                     3 * 1,
                     7 2 6}
             If you want paths to follow strictly 90 degree angles, set for loop to stop at 4 otherwise
              set the loop to stop at 8. */
            switch (i)
            {

                case 0: // top center
                    posToCheck[0] += 0;
                    posToCheck[1] += 1;
                    break;

                case 1: // right center
                    posToCheck[0] += 1;
                    posToCheck[1] += 0;
                    break;

                case 2: // bottom center
                    posToCheck[0] += 0;
                    posToCheck[1] += -1;
                    break;

                case 3: // left center
                    posToCheck[0] += -1;
                    posToCheck[1] += 0;
                    break;

                case 4: // top left
                    posToCheck[0] += -1;
                    posToCheck[1] += 1;
                    break;

                case 5: // top right
                    posToCheck[0] += 1;
                    posToCheck[1] += 1;
                    break;

                case 6: // bottom right
                    posToCheck[0] += 1;
                    posToCheck[1] += -1;
                    break;

                case 7: // bottom left
                    posToCheck[0] += -1;
                    posToCheck[1] += -1;
                    break;

                default: // unexpected case handeling
                    Debug.Log("Error: unexpected tile position request. expected integer betwenn 0 - 7");
                    posToCheck[0] += -1;
                    posToCheck[1] += 1;
                    break;
            }
            
            exists = OpenList.TryGetValue(posToCheck, out checkingTile); //checks if the tile is on the open list and saves it in the active tile slot if it is.

            if (exists)
            {
                if (checkingTile.G > (m_current.G + 10)) //if the tiles current path cost is more expensive then routing the path through the center tile, adjust it's path for this optimized route
                {
                    checkingTile.G = m_current.G + 10; //adjust the path cost
                    Array.Copy(m_current.coordinates, checkingTile.Previous, 2); //change the actual path the tile points to 
                    //OpenList.Remove(checkingTile.coordinates);
                    //OpenList.Add(checkingTile.coordinates, checkingTile); //Note this resets the object on the Dictionary but is unessesary when passing the tiles as a reference
                }

            }
            else
            {
                exists = ClosedList.TryGetValue(posToCheck, out checkingTile); //make sure the tile isn't already on the closed list
                if (!(exists) && (InstanceOfGameManager.Map[posToCheck[0], posToCheck[1]] == "e")) //confirms tile is not on the closed list and checks if the tile position is a valid space
                {
                    Array.Copy(m_current.coordinates, centerPosition, 2);

                    int cost = 10; //cost of moving to this tile
                    if(i >= 4) //if diagonal
                    {
                        cost = 14; //this is a rounding of the extra move cost for traversing a diagonal (it ends up being more then a straight line but cutting the corner ends up still better then taking two straight lines)
                    }
                    
                    OpenList.Add((int[])posToCheck.Clone(), new Tile((int[])posToCheck.Clone(), target, (int[])m_current.coordinates.Clone(), m_current.G + cost));
                }
            }
        }
	}
}



















public class Tile
{
	public int[] Previous = new int[2];
	
	public int number;
	public int[] Mtarget = new int[2];
	public int[] coordinates = new int[2];
	public int F;
	public int G;
	public int H;
	

	public Tile(int[] _coordinates, int[] _Mtarget, int[] _previous, int _G)
	{

		Array.Copy (_coordinates, coordinates, 2);
		Array.Copy (_Mtarget, Mtarget, 2);
		Array.Copy (_previous, Previous, 2);
		calcH();
		G = _G;
	}


	/// <summary>
	/// Calculate the H value
	/// </summary>
	void calcH()
	{
		H = Math.Abs (Mtarget [0] - coordinates [0]) + Math.Abs (Mtarget [1] - coordinates [1]);
		F = G + H;
	}
	
    /// <summary>
    /// Returns information about the contents of the Tile object.
    /// </summary>
    /// <returns></returns>
	public override string ToString ()
	{
		return string.Format ("Previous: " + Previous[0] + "," + Previous[1] + "\n" + "Target: " + Mtarget[0] + "," + Mtarget[1] + "\n" + "Coordinates: " + coordinates[0] + "," + coordinates[1] + "\n" + "F: " + F + "\n" + "G: " + G + "\n" + "H: " + H);
	}

}






//code below is Glen Hughes' code from a help stack overflow http://stackoverflow.com/questions/14663168/an-integer-array-as-a-key-for-dictionary
//and is needed to make the values of a int[] be the key rather then the object holding them.
//code apparently based off: http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
//Which in tern is attributed to an implementation given in Josh Bloch's Effective Java (2nd Edition)
public class MyEqualityComparer : IEqualityComparer<int[]>
{
	public bool Equals(int[] x, int[] y)
	{
		if (x.Length != y.Length)
		{
			return false;
		}
		for (int i = 0; i < x.Length; i++)
		{
			if (x[i] != y[i])
			{
				return false;
			}
		}
		return true;
	}
	
	public int GetHashCode(int[] obj)
	{
		int result = 17;
		for (int i = 0; i < obj.Length; i++)
		{
			unchecked
			{
				result = result * 23 + obj[i];
			}
		}
		return result;
	}
}






