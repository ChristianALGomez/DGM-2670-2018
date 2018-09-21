using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AISpeedUp : MonoBehaviour
{
    public FloatDataScript one;
    public FloatDataScript two;
    public FloatDataScript three;
    public int aispeed;
    //private int slow = 0, moderate = 1, fast = 2;

    private void Start()
    {
        switch (aispeed)
        {
                case 0:
                    GetComponent<FloatDataScript>();
                    break;
                case 1:
                    GetComponent<FloatDataScript>();
                    break;
                case 2:
                    GetComponent<FloatDataScript>();
                    break;
        }
    }
}
