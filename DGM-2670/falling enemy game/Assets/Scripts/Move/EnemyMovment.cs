using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour {
	
	
	private CharacterController controller;
	public EnemeyMovePattern EMove;
	

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
    
	void Update() {
		EMove.Invoke(controller, transform);
	}
}

