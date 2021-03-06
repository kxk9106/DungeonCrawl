﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    //setup
    public char[,] Map = new char[8, 18];//map of the dungeon
    AStarMovement AStar = new AStarMovement();



    //prefabs
    public GameObject EnemyPrefab;
    public GameObject[] EnemyList;
    public GameObject WallPrefab;
    public GameObject IndustructibleWallPrefab;

    public int howMany;

    public int[,] locations = new int[12, 2];//List of the rough center of each classroom to target

    // Use this for initialization
    void Start()
    {

        mapFill();//instantiates the dungeon map

        //generate walls
        Vector3 pos = new Vector3(0, 0f, 0);
        for (int yOrzOrWhatEver = 0; yOrzOrWhatEver < Map.GetLength(1); yOrzOrWhatEver++)
        {
            for (int x = 0; x < Map.GetLength(0); x++)
            {
                if (Map[x, yOrzOrWhatEver] == '2')
                {
                    if (true)//(x > 0) && (x < 9))
                    {
                        pos = new Vector3((float)((x * 5) + 2.5), 0f, (float)((yOrzOrWhatEver * 5) + 2.5));
                        Quaternion rot = Quaternion.Euler(0, 0, 0);
                        GameObject.Instantiate(WallPrefab, pos, rot);
                    }
                }
                else if (Map[x, yOrzOrWhatEver] == 'x')
                {
                    pos = new Vector3((float)((x * 5) + 2.5), 1f, (float)((yOrzOrWhatEver * 5) + 2.5));
                    Quaternion rot = Quaternion.Euler(0, 0, 0);
                    /*EnemyList[yOrzOrWhatEver] = (GameObject)*/
                    GameObject.Instantiate(EnemyPrefab, pos, rot);
                }
                else if (Map[x, yOrzOrWhatEver] == '1')
                {
                    if (true)//(x > 0) && (x < 9))
                    {
                        pos = new Vector3((float)((x * 5) + 2.5), 0f, (float)((yOrzOrWhatEver * 5) + 2.5));
                        //Debug.Log("POS: (" + pos.x + "," + pos.y + "," + pos.z + ")");
                        Quaternion rot = Quaternion.Euler(0, 0, 0);
                        GameObject.Instantiate(IndustructibleWallPrefab, pos, rot);
                    }
                }
            }
        }

        
        

        //for (int i=0; i< howMany; i++) 
        //{
        //	pos =  new Vector3(Random.Range(82, 102), 0f, Random.Range(27, 47));
        //
        //	Quaternion rot = Quaternion.Euler(0, Random.Range(0, 90), 0);
        //	GameObject.Instantiate(EnemyPrefab, pos, rot);
        //}
        //EnemyList = GameObject.FindGameObjectsWithTag ("Enemy");



    }

    // Update is called once per frame
    void Update()
    {

    }



    /// <summary>
    ///generate a map and save it to reference later
    /// </summary>
    void mapFill()
    {

        char[,] tempMap = new char[,]{ 
                {'1','1','1','1','1','1','1','1'},  
                {'0','0','2','2','2','1','0','0'},  
                {'1','1','0','x','0','0','1','1'},  
                {'0','0','1','0','1','1','1','0'},  
                {'x','1','0','0','0','0','0','0'},  
                {'0','0','1','1','2','1','1','0'},  
                {'0','1','0','0','0','1','0','1'},  
                {'0','0','0','1','0','0','0','x'},  
                {'0','1','1','x','1','1','2','0'},  
                {'0','2','1','0','0','1','0','0'},  
                {'2','2','1','0','0','0','0','0'},  
                {'1','2','1','1','2','1','1','1'},  
                {'0','0','0','0','0','0','0','0'},  
                {'0','0','0','0','0','0','1','0'},  
                {'0','1','0','1','0','1','0','2'},  
                {'0','0','x','0','0','0','0','0'},  
                {'1','0','0','0','0','0','0','0'},  
                {'1','1','1','1','1','1','1','1'}}; 




        //inverting the array because I dont feel like building maps upside down
        for (int y = 0, k = (tempMap.GetLength(0)) - 1; y < tempMap.GetLength(0); y++, k--)
        {

            for (int x = 0; x < tempMap.GetLength(1); x++)
            {
                Map[x, y] = tempMap[k, x];
            }

        }

    }




    public List<int[]> GetAStarList(GameObject m_Object)
    {
        return AStar.CalculateAStar(m_Object, Map);
    }

    public char GetPosition(int x, int y)
    {
        return Map[x, y];
    }

    public void editMap(int x, int y, char mapMarker)
    {
        Map[x, y] = mapMarker;
    }
}
