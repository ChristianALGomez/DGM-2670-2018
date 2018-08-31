using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BecomeVisible : MonoBehaviour
{

    public UnityEvent Event;

    private void OnBecameVisible()
    {
        Event.Invoke();
    }
}
