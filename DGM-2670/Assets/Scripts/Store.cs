﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{
    public Objects Available;
    public Objects Purchased;

    public void MakePurchase(Object obj)
    {
        for (var i = 0; i < Available.ObjectList.Count; i++)
        {
            var availableOject = Available.ObjectList[i];
            if (availableOject == obj)
            {
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableOject);
            }
        }
    }
}
