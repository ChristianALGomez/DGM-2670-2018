using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParpeturalCounter : MonoBehaviour
{
    public UnityEvent OnCount;
    public float Seconds = 1f;

    IEnumerator Start()
    {
        while (true)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(Seconds);
        }
    }
}
