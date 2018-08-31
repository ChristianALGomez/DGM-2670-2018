using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimatorMoveEvent : MonoBehaviour
{

    public UnityEvent Event;

    private void OnAnimatorMove()
    {
        Event.Invoke();
    }
}
