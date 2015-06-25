using UnityEngine;
using System.Collections;

public class BGLoop : MonoBehaviour {

	int numBGPanels = 6;

	float rockMax = 6.32f;
	float rockMin = 2.86f;

	void Start(){
		GameObject[] rocks = GameObject.FindGameObjectsWithTag ("rock");

		foreach(GameObject rock in rocks) {
			Vector3 pos = rock.transform.position;
			pos.y = Random.Range(rockMin, rockMax);	
			rock.transform.position = pos;
			 
		}
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Triggered : " + collider.name);

		float widhtofBGObject = ((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;

		pos.x += widhtofBGObject * numBGPanels;

		if (collider.tag == "rock") {
			pos.y = Random.Range(rockMin, rockMax);	
		}
		collider.transform.position = pos;


	}
}
