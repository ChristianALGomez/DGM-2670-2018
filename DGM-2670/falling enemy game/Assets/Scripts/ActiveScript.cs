using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{

	public GameObject self;

	private void Start()
	{
		Debug.Log("Start");
	}

	private void OnTriggerEnter(Collider collider)
	{
		Debug.Log("first");
		
		if (collider.CompareTag("Token") == collider)
		{
			Debug.Log("Match");
			self.SetActive(true);
		}
	}
}
