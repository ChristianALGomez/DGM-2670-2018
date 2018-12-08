using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Shop : ScriptableObject
{
    public Object Item1;
    public Object Item2;
    public int ItemValue;
    public int Item2Value;
    public FinalScore Cash;
    public List<Object> Purchased;
    public List<Object> Purchased2;
    public Holder Holder;

    public void Purchase()
    {
        if (Cash.Money >= ItemValue)
        {
            Purchased.Add(Item1);
            Cash.Money -= ItemValue;
            //Holder.IncrementScore(- ItemValue);
        }
    }
    
    public void PurchaseNp()
    {
        if (Cash.Money >= Item2Value)
        {
            Purchased2.Add(Item2);
            Cash.Money -= Item2Value;
            //Holder.IncrementFinalScore(- Item2Value);
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
    
    public void AddObjectToGameNp()
    {
        if (Purchased2.Count > 0)
        {
            Instantiate(Purchased2[0]);
            Purchased2.RemoveAt(0);
        }
    }
}