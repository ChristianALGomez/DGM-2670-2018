using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerStayEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnTriggerStay(Collider other)
    {
        Event.Invoke();
    }
}
