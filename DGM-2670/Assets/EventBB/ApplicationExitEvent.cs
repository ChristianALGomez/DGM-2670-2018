using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ApplicationExitEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnApplicationQuit()
    {
        Event.Invoke();
    }
    
}
