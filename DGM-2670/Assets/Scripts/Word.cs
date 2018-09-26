using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Demo")]
public class Word :ScriptableObject
{
     public UnityEvent Solved;
     
     public string TheWord;

     public void Solving()
     {
          foreach (var Letter in TheWord)
          {
              //mark as solved; 
          }
     }
}
