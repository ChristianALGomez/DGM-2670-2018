using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawn : MonoBehaviour
{

    public GameObject Sheild;
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Token") == collider)
        {
            Instantiate(Sheild);
        }
    }
}
