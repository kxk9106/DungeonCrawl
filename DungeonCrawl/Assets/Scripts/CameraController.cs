using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public bool moveOn;

	// Use this for initialization
	void Start () {
		moveOn = true;
	}
	
	// Update is called once per frame
	void Update () {
	if (moveOn) {
			this.transform.position += new Vector3(0,0,1) * Time.fixedDeltaTime;
		}
	}
}
