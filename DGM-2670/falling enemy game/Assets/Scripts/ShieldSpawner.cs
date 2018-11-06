using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

[CreateAssetMenu]
public class ShieldSpawner : ScriptableObject
{
    public GameObject Shield;

    public void SpawnShield()
    {
        Instantiate(Shield);
    }


}
