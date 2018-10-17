using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
