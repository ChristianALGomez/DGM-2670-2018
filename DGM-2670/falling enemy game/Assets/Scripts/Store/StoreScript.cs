﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

	public PurchaseableObjects Available;
	public PurchaseableObjects Purchased;
	public GameObject Canvas;
	public GameObject Button;
	public IntData Cash;
	public int TotalValue = 3000;

	public UnityEvent MadePurchase;
	
	private void OnEnable()
	{
		TotalValue = 0;
		foreach (var item in Available.ObjectList)
		{
			var newItem = item;
			TotalValue += newItem.Value;
		}
		TotalValue %= 75;
	}

	public void BuildUI()
	{
		var newCanvas = Instantiate(Canvas);
		
		foreach (var obj in Available.ObjectList)
		{
			var newButton = Instantiate(Button, newCanvas.GetComponentInChildren<VerticalLayoutGroup>().transform);
			var buttonComponent = newButton.GetComponent<Button>();
			var imageComponent = newButton.GetComponent<Image>();
			imageComponent.sprite = obj.PreviewArt;
			//imageComponent.sprite
			buttonComponent.onClick.AddListener(() => { MakePurchase(obj);});
			buttonComponent.onClick.AddListener(() => { DisableButton(obj, buttonComponent);});
			
			var label = newButton.GetComponentInChildren<Text>();
			label.text = obj.name;
		}
	}

	private void DisableButton(PurchasableObject obj, Button btn)
	{
		if (obj.Perpetual)
		{
			btn.interactable = false;
			btn.onClick.RemoveAllListeners();
		}
	}
	
	
	public void MakePurchase(PurchasableObject obj)
	{
		Debug.Log("test");
		for (var i = 0; i < Available.ObjectList.Count; i++)
		{
			var availableObject = Available.ObjectList[i];

			if (availableObject != obj || Cash.Value < availableObject.Value) continue;
			Cash.Value -= availableObject.Value;
			Purchased.ObjectList.Add(obj);
			
			if (availableObject.Perpetual)
			{
				Available.ObjectList.Remove(availableObject);
			}
			MadePurchase.Invoke();
		}
	}

	public void PurchaseAll()
	{
		if (Cash.Value >= TotalValue)
		{
			Cash.Value -= TotalValue;
			for (var i = 0; i < Available.ObjectList.Count; i++)
			{
				var item = Available.ObjectList[i];
				Purchased.ObjectList.Add(item);
			}

			Available.ObjectList.Clear();
		}
	}
}