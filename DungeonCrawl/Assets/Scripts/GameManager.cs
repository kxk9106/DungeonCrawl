using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//setup
	public string[,] Map = new string[135, 120];//map of the school



	//prefabs
	public GameObject NewGuy;
	public  GameObject[] students;

	public int howMany;

	public int[,] locations = new int[12,2];//List of the rough center of each classroom to target

	// Use this for initialization
	void Start () {
		locationFill ();
		mapFill ();//instantiates the school map

		Vector3 pos = new Vector3(Random.Range(82, 102), 0f, Random.Range( -27, 47));
	
		//for (int i=0; i< howMany; i++) 
		//{
		//	pos =  new Vector3(Random.Range(82, 102), 0f, Random.Range(27, 47));
        //
		//	Quaternion rot = Quaternion.Euler(0, Random.Range(0, 90), 0);
		//	GameObject.Instantiate(NewGuy, pos, rot);
		//}
		//students = GameObject.FindGameObjectsWithTag ("Student");

	}
	
	// Update is called once per frame
	void Update () {
	
	}




	void locationFill()
	{
		//Cafe 
		locations [0, 0] = 92; //x co-ordinate
		locations [0, 1] = 37; //z co-ordinate
		
		//A
		locations [1, 0] = 106; //x co-ordinate
		locations [1, 1] = 101; //z co-ordinate
		
		//B
		locations [2, 0] = 78; //x co-ordinate
		locations [2, 1] = 101; //z co-ordinate
		
		//C
		locations [3, 0] = 92; //x co-ordinate
		locations [3, 1] = 76; //z co-ordinate
		
		//D
		locations [4, 0] = 50; //x co-ordinate
		locations [4, 1] = 81; //z co-ordinate
		
		//E
		locations [5, 0] = 30; //x co-ordinate
		locations [5, 1] = 81; //z co-ordinate
		
		//F
		locations [6, 0] = 10; //x co-ordinate
		locations [6, 1] = 81; //z co-ordinate
		
		//G
		locations [7, 0] = 10; //x co-ordinate
		locations [7, 1] = 47; //z co-ordinate
		
		//H
		locations [8, 0] = 10; //x co-ordinate
		locations [8, 1] = 19; //z co-ordinate
		
		//I
		locations [9, 0] = 44; //x co-ordinate
		locations [9, 1] = 37; //z co-ordinate
		
		//Girls bathroom "BRG"
		locations [10, 0] = 33; //x co-ordinate
		locations [10, 1] = 54; //z co-ordinate
		
		//Boys bathroom "BRB"
		locations [11, 0] = 54; //x co-ordinate
		locations [11, 1] = 54; //z co-ordinate
	}

	

	/// <summary>
	///I apologize for the horror you see here I found no good way to inhabit the array short of working out text file reading and it sounds like making a relative path is a nightmare. 
	/// </summary>
	void mapFill ()
	{

		string temp1 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp2 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp3 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp4 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp5 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp6 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp7 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeewwwwwwwwwwwwwwwwwweeeewwwwwwwwwwwweeeeeeewwwwwwwwwwwwwwweeeeewwwwwwwwww";
		string temp8 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp9 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp10 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp11 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp12 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp13 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp14 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp15 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp16 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp17 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp18 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp19 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp20 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp21 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp22 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp23 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp24 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp25 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp26 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp27 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp28 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp29 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp30 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeewweeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp31 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeewwwwwwwwww";
		string temp32 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeewwwwwwwwww";
		string temp33 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp34 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp35 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp36 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp37 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp38 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp39 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp40 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp41 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp42 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp43 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp44 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp45 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp46 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp47 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp48 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp49 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp50 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp51 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp52 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp53 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp54 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp55 = "weeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwww";
		string temp56 = "wwwweeeewwwwwwwwwwwwwwwwwwwwweeeewwwwwwwwwwwwwwwwweeeewwwwweeeeewwwwwwwwwwwwwwwwwwwwwwwwwweeeewwwwwwwwwwwwwwwwwwwwwwwwwweeeeewwwwwwwwww";
		string temp57 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp58 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp59 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp60 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp61 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwww";
		string temp62 = "wwwweeeewwwwwwwwwwwwweeeeeewwwwwwwwwwweeeewweeeewwwwwwwwwwweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp63 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeweeeewweeeeweeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp64 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeweeeewweeeeweeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp65 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeweeeewweeeeweeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp66 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeweeeewweeeeweeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp67 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeweeeewweeeeweeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp68 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeweeeewweeeeweeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp69 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeewweeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp70 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeewweeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp71 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeewweeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp72 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeewweeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeew";
		string temp73 = "weeeeeeeeeeeeeeeeeeeweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeew";
		string temp74 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeew";
		string temp75 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeew";
		string temp76 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeew";
		string temp77 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp78 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp79 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp80 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp81 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp82 = "weeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp83 = "weeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp84 = "weeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp85 = "weeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp86 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp87 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp88 = "wwwwwwwwwwwwwwwwwwwwweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp89 = "wwwwwwwwwwwwwwwwwwwwweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp90 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp91 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp92 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp93 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp94 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp95 = "weeeeeeeeeeeeeeeeeeeweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp96 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp97 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeweeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp98 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp99 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp100 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp101 = "weeeeeeeeeeeeeeeeeeeweeeeeewwwwwwwwwwwwwweeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp102 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp103 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeew";
		string temp104 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp105 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp106 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp107 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp108 = "weeeeeeeeeeeeeeeeeeeweeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp109 = "weeeeeeeeeeeeeeeeeeeweeeeeewwwwwwwwwwwwwwwwwwwwwwwwweeeeewweeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp110 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp111 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp112 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp113 = "weeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp114 = "weeeeeeeeeeeeeeeeeeeweeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp115 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp116 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp117 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp118 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp119 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwweeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
		string temp120 = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";









		//Map = new int[,]

		for(int j = 0; j < (Map.GetLength(0)); j++)
		{



			Map[j,0] = temp120[j].ToString();
			Map[j,1] = temp119[j].ToString();
			Map[j,2] = temp118[j].ToString();
			Map[j,3] = temp117[j].ToString();
			Map[j,4] = temp116[j].ToString();
			Map[j,5] = temp115[j].ToString();
			Map[j,6] = temp114[j].ToString();
			Map[j,7] = temp113[j].ToString();
			Map[j,8] = temp112[j].ToString();
			Map[j,9] = temp111[j].ToString();
			Map[j,10] = temp110[j].ToString();
			Map[j,11] = temp109[j].ToString();
			Map[j,12] = temp108[j].ToString();
			Map[j,13] = temp107[j].ToString();
			Map[j,14] = temp106[j].ToString();
			Map[j,15] = temp105[j].ToString();
			Map[j,16] = temp104[j].ToString();
			Map[j,17] = temp103[j].ToString();
			Map[j,18] = temp102[j].ToString();
			Map[j,19] = temp101[j].ToString();
			Map[j,20] = temp100[j].ToString();
			Map[j,21] = temp99[j].ToString();
			Map[j,22] = temp98[j].ToString();
			Map[j,23] = temp97[j].ToString();
			Map[j,24] = temp96[j].ToString();
			Map[j,25] = temp95[j].ToString();
			Map[j,26] = temp94[j].ToString();
			Map[j,27] = temp93[j].ToString();
			Map[j,28] = temp92[j].ToString();
			Map[j,29] = temp91[j].ToString();
			Map[j,30] = temp90[j].ToString();
			Map[j,31] = temp89[j].ToString();
			Map[j,32] = temp88[j].ToString();
			Map[j,33] = temp87[j].ToString();
			Map[j,34] = temp86[j].ToString();
			Map[j,35] = temp85[j].ToString();
			Map[j,36] = temp84[j].ToString();
			Map[j,37] = temp83[j].ToString();
			Map[j,38] = temp82[j].ToString();
			Map[j,39] = temp81[j].ToString();
			Map[j,40] = temp80[j].ToString();
			Map[j,41] = temp79[j].ToString();
			Map[j,42] = temp78[j].ToString();
			Map[j,43] = temp77[j].ToString();
			Map[j,44] = temp76[j].ToString();
			Map[j,45] = temp75[j].ToString();
			Map[j,46] = temp74[j].ToString();
			Map[j,47] = temp73[j].ToString();
			Map[j,48] = temp72[j].ToString();
			Map[j,49] = temp71[j].ToString();
			Map[j,50] = temp70[j].ToString();
			Map[j,51] = temp69[j].ToString();
			Map[j,52] = temp68[j].ToString();
			Map[j,53] = temp67[j].ToString();
			Map[j,54] = temp66[j].ToString();
			Map[j,55] = temp65[j].ToString();
			Map[j,56] = temp64[j].ToString();
			Map[j,57] = temp63[j].ToString();
			Map[j,58] = temp62[j].ToString();
			Map[j,59] = temp61[j].ToString();
			Map[j,60] = temp60[j].ToString();
			Map[j,61] = temp59[j].ToString();
			Map[j,62] = temp58[j].ToString();
			Map[j,63] = temp57[j].ToString();
			Map[j,64] = temp56[j].ToString();
			Map[j,65] = temp55[j].ToString();
			Map[j,66] = temp54[j].ToString();
			Map[j,67] = temp53[j].ToString();
			Map[j,68] = temp52[j].ToString();
			Map[j,69] = temp51[j].ToString();
			Map[j,70] = temp50[j].ToString();
			Map[j,71] = temp49[j].ToString();
			Map[j,72] = temp48[j].ToString();
			Map[j,73] = temp47[j].ToString();
			Map[j,74] = temp46[j].ToString();
			Map[j,75] = temp45[j].ToString();
			Map[j,76] = temp44[j].ToString();
			Map[j,77] = temp43[j].ToString();
			Map[j,78] = temp42[j].ToString();
			Map[j,79] = temp41[j].ToString();
			Map[j,80] = temp40[j].ToString();
			Map[j,81] = temp39[j].ToString();
			Map[j,82] = temp38[j].ToString();
			Map[j,83] = temp37[j].ToString();
			Map[j,84] = temp36[j].ToString();
			Map[j,85] = temp35[j].ToString();
			Map[j,86] = temp34[j].ToString();
			Map[j,87] = temp33[j].ToString();
			Map[j,88] = temp32[j].ToString();
			Map[j,89] = temp31[j].ToString();
			Map[j,90] = temp30[j].ToString();
			Map[j,91] = temp29[j].ToString();
			Map[j,92] = temp28[j].ToString();
			Map[j,93] = temp27[j].ToString();
			Map[j,94] = temp26[j].ToString();
			Map[j,95] = temp25[j].ToString();
			Map[j,96] = temp24[j].ToString();
			Map[j,97] = temp23[j].ToString();
			Map[j,98] = temp22[j].ToString();
			Map[j,99] = temp21[j].ToString();
			Map[j,100] = temp20[j].ToString();
			Map[j,101] = temp19[j].ToString();
			Map[j,102] = temp18[j].ToString();
			Map[j,103] = temp17[j].ToString();
			Map[j,104] = temp16[j].ToString();
			Map[j,105] = temp15[j].ToString();
			Map[j,106] = temp14[j].ToString();
			Map[j,107] = temp13[j].ToString();
			Map[j,108] = temp12[j].ToString();
			Map[j,109] = temp11[j].ToString();
			Map[j,110] = temp10[j].ToString();
			Map[j,111] = temp9[j].ToString();
			Map[j,112] = temp8[j].ToString();
			Map[j,113] = temp7[j].ToString();
			Map[j,114] = temp6[j].ToString();
			Map[j,115] = temp5[j].ToString();
			Map[j,116] = temp4[j].ToString();
			Map[j,117] = temp3[j].ToString();
			Map[j,118] = temp2[j].ToString();
			Map[j,119] = temp1[j].ToString();



		}

	}



	/// <summary>
	/// This method polls a random room from the list to be used as a
	/// classroom assignment.
	/// </summary>
	int[] Randomlocation ()
	{
		int[] temp = new int[2];
		int randomRoom = Random.Range (0, 12);
		temp [0] = locations [randomRoom, 0];
		temp [1] = locations [randomRoom, 1];
		
		return(temp);
	}



}










