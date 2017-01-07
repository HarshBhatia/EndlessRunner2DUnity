using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldLooper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D target){
		Debug.Log ("Collision");
		target.transform.Translate (new Vector3 (150, 0, 0));
	}

	void OnCollisionEnter2D(Collision2D target){
		Debug.Log ("Collision");
		target.transform.Translate (new Vector3 (150, 0, 0));
	}
}
