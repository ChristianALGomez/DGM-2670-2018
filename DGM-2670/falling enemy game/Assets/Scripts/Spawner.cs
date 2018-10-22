using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public float MaxNum;
    public float MinNum;
    
    
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(MinNum, MaxNum), 0, Random.Range(MinNum, MaxNum));
        Instantiate(obj, position, Quaternion.identity);
    }
}
