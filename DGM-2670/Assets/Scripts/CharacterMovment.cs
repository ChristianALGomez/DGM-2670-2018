﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class CharacterMovment : MonoBehaviour
{
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	public FloatDataScript MoveX, MoveY, MoveZ;
	
	
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	public FloatDataScript MoveX, MoveY, MoveZ;
    
	void Update() {
        
		if (controller.isGrounded) {
			moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
            
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}