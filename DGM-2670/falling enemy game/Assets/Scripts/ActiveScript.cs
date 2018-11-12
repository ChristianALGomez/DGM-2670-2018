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

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Match");
	}

	/*private void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Token") == collider)
		{
			self.SetActive(true);
		}
	}*/
}
