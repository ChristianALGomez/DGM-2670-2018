using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{
    public Objects Available;
    public Objects Purchased;
    public IntData Cash;
    public int TotalValue = 3000;

    public UnityEvent MadePurchase;

    public void MakePurchase(PurchasableObject obj)
    {
        for (var i = 0; i < Available.ObjectList.Count; i++)
        {
            PurchasableObject availableOject = Available.ObjectList[i] as PurchasableObject;
            
            if (availableOject == obj && Cash.Value >= availableOject.Value)
            {
                Cash.Value -= availableOject.Value;
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableOject);
                MadePurchase.Invoke();
            }
        }
    }

    public void PurchaseAll()
    {
        if (Cash.Value >= TotalValue)
        {
            Cash.Value -= TotalValue;
            for (var i = 0; i < Available.ObjectList.Count; i++)
            {
                var item = Available.ObjectList[0];
                Purchased.ObjectList.Add(item);
                Available.ObjectList.RemoveAt(0);
            }
        }
    }
}