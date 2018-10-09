using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerColliderHitEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Event.Invoke();
    }
}
