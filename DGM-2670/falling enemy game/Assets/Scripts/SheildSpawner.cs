using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheildSpawner : MonoBehaviour
{

    public GameObject Shield;
    public Transform Spawnpoint;

    


    private void Spawn()
    {
        Shield = GameObject.Find("Shield");
        Instantiate(Shield);
        /*if (collider.CompareTag("Token") == collider)
        {
            Instantiate(Shield, Spawnpoint.position, Spawnpoint.rotation);
        }*/

    }
}
