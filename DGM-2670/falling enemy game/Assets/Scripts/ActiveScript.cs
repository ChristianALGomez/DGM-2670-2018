using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{

	public GameObject self;

	private void Start()
	{
		self.SetActive(true);
	}

	/*private void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Token") == collider)
		{
			self.SetActive(true);
		}
	}*/
}
