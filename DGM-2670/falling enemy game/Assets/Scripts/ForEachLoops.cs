using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ForEachLoops : ScriptableObject
{
    public FloatDataScript RandomSpeed;
    
    public List<FloatDataScript> SpeedOptions;

    private void OnEnable()
    {
        var randomNum = Random.Range(0, SpeedOptions.Count - 1);

       //for (int i = 0; i < SpeedOptions -1 ; i++)
        {
            //if (i == randomNum)
            {
                //RandomSpeed = SpeedOptions[i];
            }
        }
    }
}
