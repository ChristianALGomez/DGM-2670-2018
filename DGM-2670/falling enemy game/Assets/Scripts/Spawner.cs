using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Spawner : ScriptableObject
{
    public GameObject obj;
    public float MaxNum;
    public float MinNum;
    public float Hi;
    
    public void Call(GameObject instance)
    {
        Vector3 position = new Vector3(Random.Range(MinNum, MaxNum), Hi, Random.Range(0, 0));
        Instantiate(obj, position, Quaternion.identity);
        //Instantiate(obj);

    }
}
