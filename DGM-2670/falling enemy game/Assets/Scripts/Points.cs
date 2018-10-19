using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

	public int value;
	private GameObject Holder;
	public Holder myHolder;
	public Collider Ground;
	//public PrefabData Ground;

	private void Start()
	{
		myHolder = FindObjectOfType<Holder>().GetComponent<Holder>();
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
		if (Ground == collider)
		{
			myHolder.IncrementScore(value);
			Destroy(gameObject);
		}
	}
}