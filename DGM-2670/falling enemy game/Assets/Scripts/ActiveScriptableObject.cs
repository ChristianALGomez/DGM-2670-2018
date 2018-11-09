using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ActiveScriptableObject : ScriptableObject
{
    public GameObject obj;

    public void TurnOn()
    {
        Instantiate(obj);
    }
    
    
}
