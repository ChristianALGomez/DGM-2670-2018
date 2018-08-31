﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEnter : MonoBehaviour
{

    public UnityEvent Event;

    private void OnCollisionEnter(Collision other)
    {
        Event.Invoke();
    }
}
