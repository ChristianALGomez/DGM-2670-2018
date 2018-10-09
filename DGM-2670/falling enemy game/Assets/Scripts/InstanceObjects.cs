using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class InstanceObjects : ScriptableObject {
    
    public void call(GameObject instance)
    {
        Instantiate(instance);
    }
}
