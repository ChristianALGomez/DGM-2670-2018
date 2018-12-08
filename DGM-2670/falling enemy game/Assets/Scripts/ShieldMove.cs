﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMove : MonoBehaviour {
	public GameObject player;       

	private Vector3 offset;  
	void Start ()
	{
		player = GameObject.Find("Player");
		offset = transform.position;
	}
    
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
	
}