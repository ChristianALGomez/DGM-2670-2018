using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseOverEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnMouseOver()
    {
        Event.Invoke();
    }
}
