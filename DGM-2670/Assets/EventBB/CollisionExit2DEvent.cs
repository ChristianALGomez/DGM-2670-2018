using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionExit2DEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnCollisionExit2D(Collision2D other)
    {
        Event.Invoke();
    }
}
