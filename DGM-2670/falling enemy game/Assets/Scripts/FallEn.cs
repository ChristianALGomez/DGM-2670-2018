using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallEn : MonoBehaviour
{

    public FloatDataScript FallSpeed;
    
    void Falling()
    {
        Physics.gravity = new Vector3(0, FallSpeed.value, 0);
    }


}
