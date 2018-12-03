using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FinalScore : ScriptableObject
{
    public int money;


    public void RestartFinalScore()
    {
        money = 0;
    }
    
}