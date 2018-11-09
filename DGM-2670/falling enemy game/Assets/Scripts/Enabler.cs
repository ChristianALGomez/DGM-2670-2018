using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Token") == other)
        {
            switch (other.gameObject.name)
            {
                case "enable":
                    SetActiveScript.enable = false;
                    break;
                case "Disable":
                    SetActiveScript.enable = true;
                    break;
                        
            }
        }
        
    }
}
