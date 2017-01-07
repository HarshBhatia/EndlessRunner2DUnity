using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private Animator anim;
	private Rigidbody2D rb;
	public Vector2 jumpForce;
	public GameObject world;

	// Use this for initialization
	void Start () {


		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			anim.SetInteger("State",1);
			jump ();
		}
	}

	void jump(){
		rb.AddForce ( jumpForce ,ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D(Collision2D target){
		anim.SetInteger("State",0);
	}

	void OnTriggerEnter2D(Collider2D target){
		Debug.Log ("Boundss");
		if (target.gameObject.tag == "Cactus" || target.gameObject.tag == "Bounds") {
			anim.SetInteger("State",2);
			world.GetComponent<WorldMover>().stopMoving ();
		}
	}
}
