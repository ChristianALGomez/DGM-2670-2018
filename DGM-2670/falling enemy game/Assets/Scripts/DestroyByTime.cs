using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour 
{
    private void Update()
    {
        Destroy(gameObject, 4);
    }

    
}
