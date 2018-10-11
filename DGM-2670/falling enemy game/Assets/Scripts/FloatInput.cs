using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

[CreateAssetMenu(menuName = "Float/FloatInput")]
public class FloatInput : FloatDataScript
{
    public string InputType;

    public override float Value
    { 
        get { return Input.GetAxis(InputType)*value;}
    }
}