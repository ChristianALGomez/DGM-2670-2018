using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") == collider)
        {
            Destroy(player);
        }
    }
}
