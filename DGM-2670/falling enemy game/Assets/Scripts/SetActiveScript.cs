using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveScript : MonoBehaviour
{

    public GameObject objectEnable;
    public static bool enable = false;


    private void Update()
    {
        if (enable)
        {
            objectEnable.SetActive(true);
        }
        else
        {
            objectEnable.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("working");
    }
}
