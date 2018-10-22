using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class UpScore : ScriptableObject
{


    public Holder MyHolder;
    public GameObject Holder;
    public int value;




    public void Score()
    {
        MyHolder.IncrementScore(value);
    }
}
