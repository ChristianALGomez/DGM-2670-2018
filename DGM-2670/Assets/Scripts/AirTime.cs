using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirTime : MonoBehaviour {

	private Text label;

	
    
	IEnumerator Start()
	{	
		label = GetComponent<Text>();

		int number = 0;

		while (number > 0)
		{
			yield return new WaitForSeconds(0.1f);
			label.text = number.ToString();
			number++;
		}
	}
}
