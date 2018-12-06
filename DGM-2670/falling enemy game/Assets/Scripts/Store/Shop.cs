using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Shop : ScriptableObject
{
    public Object Item;
    public int ItemValue;
    public FinalScore Cash;
    public List<Object> Purchased;

    public void Purchase()
    {
        if (Cash.Money >= ItemValue)
        {
            Purchased.Add(Item);
            Cash.Money -= ItemValue;
        }
    }


    public void AddObjectToGame()
    {
        if (Purchased.Count > 0)
        {
            Instantiate(Purchased[0]);
            Purchased.RemoveAt(0);
        }
    }
}