using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{

    private Vector3 position;
    private FloatDataScript Speed;

    private void OnTriggerEnter(Collider other)
    {
        position = other.transform.position;
    }

    public void Call()
    {
        StartCoroutine(MoveTo());
    }

    IEnumerator MoveTo()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            transform.position = Vector3.Lerp(transform.position, position, Speed.value);
        }
    }
}
