using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerStay2DEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnTriggerStay2D(Collider2D other)
    {
        Event.Invoke();
    }
}
