using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheildSpawner : MonoBehaviour
{

    public GameObject Shield;
    public Transform Spawnpoint;
    
    /*private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Token") == collider)
        {
            Instantiate(gameObject);
        }
    }*/

    private void OnTriggerEnter(Collider obj)
    {

        Instantiate(Shield);
        /*if (collider.CompareTag("Token") == collider)
        {
            Instantiate(Shield, Spawnpoint.position, Spawnpoint.rotation);
        }*/

    }
}
