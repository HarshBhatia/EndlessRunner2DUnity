using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMover : MonoBehaviour {

	public float speed;

	private bool stopWorld = false;

	private Vector3 speedVector;

	void Start ()
	{
		
		speedVector = new Vector3 (-1, 0, 0) * speed;
	}	

	void Update ()
	{	if(!stopWorld)
		transform.Translate(speedVector * Time.deltaTime);
	}
	public void stopMoving(){
		Debug.Log ("Stop the world!");
		stopWorld = true;
	}
}
