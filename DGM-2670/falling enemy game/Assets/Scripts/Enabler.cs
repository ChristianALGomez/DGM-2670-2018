using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{

    public GameObject obj;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 12)
        {
            obj.SetActive(true);
        }
        
    }
}

