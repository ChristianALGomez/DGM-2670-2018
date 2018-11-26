using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.Events;

public class EventSheild : MonoBehaviour
{

    public UnityEvent Spawn;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Token") == collider)
        {
            Spawn.Invoke();
        }
    }
}
