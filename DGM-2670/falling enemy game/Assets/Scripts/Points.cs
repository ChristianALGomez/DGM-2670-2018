using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

	public int value;
	private GameObject Holder;
	public Holder myHolder;
	//public GameObject Ground;
	//public PrefabData Ground;
	//public LayerMask Ground;

	private void Start()
	{
		myHolder = FindObjectOfType<Holder>().GetComponent<Holder>();
		//Ground = GameObject.Find("Ground");
	}

	/*private void OnTriggerEnter(Collider collider)
	{
		if (Object)
		{
			myHolder.IncrementScore(value);
			Destroy(gameObject);
		}
	}*/

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Ground")  == collider || collider.CompareTag("Points") == collider)
		{
			myHolder.IncrementScore(value);
		}
	}
	
	
	
	
}