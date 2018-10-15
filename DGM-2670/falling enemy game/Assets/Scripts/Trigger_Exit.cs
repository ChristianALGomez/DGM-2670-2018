using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Exit : MonoBehaviour {
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
