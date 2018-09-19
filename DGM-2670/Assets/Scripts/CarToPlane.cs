using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarToPlane : MovePattern
{
    private bool Switch;
    public MovePattern car;
    public MovePattern plane;
    
    public override void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform);
           Switch = true;
        }
        else
        {
            if (Switch)
            {
                Move(transform);
                Switch = false;
            }
        }

        Move(controller);
    }
}