using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ApplicationPauseEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnApplicationPause(bool pauseStatus)
    {
        Event.Invoke();
    }
}
