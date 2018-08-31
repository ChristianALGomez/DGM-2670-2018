using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BecomeInvisible : MonoBehaviour
{

    public UnityEvent Event;

    private void OnBecameInvisible()
    {
        Event.Invoke();
    }
}
