using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {
	
	float flySpeed = 200f;
	float forwardSpeed = 2f;

	bool death = false;
	float deathCooldown;


	bool didFly = false;

	// Use this for initialization
	void Start () {
	
	}

	void Update(){
		if (death) {
			deathCooldown -= Time.deltaTime;

			if(deathCooldown <= 0){
				Application.LoadLevel("awal");
			}
		
		}

		if(Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			didFly = true;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (death)
						return;

		rigidbody2D.AddForce (Vector2.right * forwardSpeed);

		if (didFly) {
			rigidbody2D.AddForce (Vector2.up * flySpeed);
			didFly = false;
		}

	}

	void OnCollisionEnter2D(Collision2D collision){
		death = true;
		deathCooldown = 0.5f;
	}

}
