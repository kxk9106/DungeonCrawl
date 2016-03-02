﻿using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {
	Animator ani;
	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StopSwinging()
	{
		ani.SetBool ("isSwinging", false);
	}
}
