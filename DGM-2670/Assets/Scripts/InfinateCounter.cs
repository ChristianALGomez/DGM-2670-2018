using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class InfinateCounter : MonoBehaviour
{
    public UnityEvent Oncount;
    public float Seconds = 1;



        IEnumerator Start()
        {
            while (true)
            {
                Oncount.Invoke();
                yield return new WaitForSeconds(Seconds);
            }
        }
    }