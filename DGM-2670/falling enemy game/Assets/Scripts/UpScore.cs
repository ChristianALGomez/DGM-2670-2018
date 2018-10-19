using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpScore : MonoBehaviour
{


    public Holder myHolder;
    public int value;
    
    private void PointIncrease()
    {
        myHolder.IncrementScore(value);
    }
}
