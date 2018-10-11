using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

[CreateAssetMenu(menuName = "Float/FloatBool")]
public class FloatBool : FloatInput
{
    public override float Value
    {
        get
        {
            if (Input.GetButton(InputType))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }
    }
}