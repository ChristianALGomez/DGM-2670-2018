using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter2DEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Event.Invoke();
    }
   
}
