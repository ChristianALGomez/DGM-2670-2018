using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EVv2 : MonoBehaviour {
    
    public UnityEvent Event;
    public UnityEvent Stop;

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        Stop.Invoke();
    }
}
