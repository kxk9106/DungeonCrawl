using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class AStarMovement : MonoBehaviour {

	//setup

    /// <summary>
    /// Target position
    /// </summary>
    int[] target = new int[2];

    /// <summary>
    /// Start position
    /// </summary>
	int[] start = new int[2];

    public char[,] Map = new char[8, 18];
	public GameObject Point;
	public GameObject[] DirCube;



	Tile tileTarget;
	
	List<int[]> Path = new List<int[]>(); //Holds the final path built from a series of points

	Dictionary<int[] , Tile> OpenList = new Dictionary<int[] , Tile>(new MyEqualityComparer());
	Dictionary<int[] , Tile> ClosedList = new Dictionary<int[] , Tile>(new MyEqualityComparer());


	
	GameManager InstanceOfGameManager;
    GameObject InstanceOfPlayer;
	


	void Awake ()
	{
		InstanceOfGameManager = GameObject.FindGameObjectsWithTag("MainGo")[0].GetComponent<GameManager>();
        //InstanceOfPlayer = GameObject.FindGameObjectsWithTag("Player")[0];
	}

	// Use this for initialization
	void Start () {
		//CalculateAStar ();

	}
	

	// Update is called once per frame
	void Update () {

	
	}



    /// <summary>
    /// Calculates an AStar path to a target
    /// </summary>
	public List<int[]> CalculateAStar(GameObject m_requester, char[,] m_Map)
	{
        target = new int[2];
        start = new int[2];
        Path = new List<int[]>(); //Holds the final path built from a series of points

        OpenList = new Dictionary<int[], Tile>(new MyEqualityComparer());
        ClosedList = new Dictionary<int[], Tile>(new MyEqualityComparer());

        Map = m_Map;
        InstanceOfPlayer = GameObject.FindGameObjectsWithTag("Player")[0];

		start [0] = ((int)m_requester.transform.position.x / 5);
		start [1] = ((int)m_requester.transform.position.z / 5);
        
        target[0] = ((int)InstanceOfPlayer.transform.position.x / 5);
        target[1] = ((int)InstanceOfPlayer.transform.position.z / 5);
        
		Tile firstNode = new Tile (start, target, start, 0);
		OpenList.Add (firstNode.coordinates, firstNode); //place root node on the open list

		//int cycles = 0;
		while ((!(ClosedList.ContainsKey(target))) && (OpenList.Count > 0)) //function stops when the path leads to the target
		{
			//cycles++;

            
			int low = 74612638; //holds the current path efficiency record to be checked against (starts out with a massive place holder record)
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
			bool well = OpenList.TryGetValue(lowKey, out temp55);
            //Debug.Log("Well? " + well);
			ClosedList.Add(lowKey,temp55);
			OpenList.Remove(lowKey);


			Tile Current = new Tile(new int[2], new int[2], new int[2], 0);


			bool isthere = false;
			isthere = ClosedList.TryGetValue(lowKey, out Current);
            //Debug.Log("isThere?: " + isthere);


            //Debug.Log("Current coordinates: " + Current.coordinates[0] + "," + Current.coordinates[1] + " Current Tile: " + Current.ToString());
            CheckSurroundings(Current.coordinates, Current); //check surrounding tiles
            //Debug.Log("But did I make it here?");
            
		}

		
		

        

		Tile Sorter;
		bool exists = ClosedList.TryGetValue (target, out Sorter); //Since the completed list will always end on the target, the program searches for the path there and iterates back through the doubley linked list of tiles till it reaches the head.
        if (exists)
        {
            while (/*(Sorter.Previous != null) && */(Sorter.Previous[0] != Sorter.coordinates[0]) || (Sorter.Previous[1] != Sorter.coordinates[1])) //The path head points to itself as the previous node, so the program checks for this to determine if its at the end
            {

                // Code to create an object at each point in the path
                //Vector3 pos = new Vector3(Sorter.coordinates[0], 0f, Sorter.coordinates[1]);
                //
                //Quaternion rot = Quaternion.LookRotation(new Vector3(Sorter.Previous[0], 0f, Sorter.Previous[1]));
                //GameObject.Instantiate(Point, pos, rot);

                


                Path.Add((int[])Sorter.coordinates.Clone()); //adds the coordinates to the path (note: the resulting path is backwards at this stage)

                ClosedList.TryGetValue(new int[] { Sorter.Previous[0], Sorter.Previous[1] }, out Sorter);
            }
            Path.Reverse(); //reverses the list so that slot 0 is the path head and the last item is the destination
        }

        return Path;
			

		//for (int i = 0; i < Path.Count; i++)
		//{
		//	Debug.Log("The path: " + Path[i][0] + "," + Path[i][1]); //how to iterate through path
		//}
		
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
                    //Debug.Log("Error: unexpected tile position request. Expected integer between 0 - 7");
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

                if (!(exists) && (posToCheck[0] >= 0) && (posToCheck[0] < Map.GetLength(0)) && (posToCheck[1] >= 0) && (posToCheck[1] < Map.GetLength(1)) && (Map[posToCheck[0], posToCheck[1]] != '1') && (Map[posToCheck[0], posToCheck[1]] != '2')) //confirms tile is not on the closed list and checks if the tile position is a valid space
                {
                    
                    Array.Copy(m_current.coordinates, centerPosition, 2);

                    int cost = 10; //cost of moving to this tile
                    if (i >= 4) //if diagonal
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






