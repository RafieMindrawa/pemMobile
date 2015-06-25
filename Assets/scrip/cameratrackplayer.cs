﻿using UnityEngine;
using System.Collections;

public class cameratrackplayer : MonoBehaviour {

	Transform player;
	float offsetx;

	// Use this for initialization
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

		if (player_go == null) {
			Debug.LogError("ora ketemu player");
			return;
		}

		player = player_go.transform;
		offsetx = transform.position.x - player.position.x;

	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetx;
			transform.position=pos;
		}
	}
}
