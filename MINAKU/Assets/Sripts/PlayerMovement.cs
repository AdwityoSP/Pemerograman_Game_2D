﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public CharacterController2D kontroler;
	private float moveX;
	public float kecepatanjalan = 20;
	private bool lompat = false;
	private bool nunduk = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxisRaw ("Horizontal") * kecepatanjalan;

		if (Input.GetButtonDown ("Jump")) {
			lompat = true;
		}

		if (Input.GetButtonDown ("Crouch")) {
			nunduk = true;
		} else if (Input.GetButtonUp ("Crouch")) {
			nunduk = false;
		}
	}

	void FixedUpdate(){
		kontroler.Move (moveX * Time.fixedDeltaTime, nunduk, lompat);
		lompat = false;
	}
}
