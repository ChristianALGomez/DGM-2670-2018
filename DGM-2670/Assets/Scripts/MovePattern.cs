using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject
{
    public FloatDataScript jumpSpeed;
    public FloatDataScript gravity;

    public FloatDataScript MoveX, MoveY, MoveZ;
    public FloatDataScript RotX, RotY, RotZ;
	
    private Vector3 moveDirection;
    private Vector3 rotDirection;

    public void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded) {
            moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
            rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
            transform.Rotate(rotDirection);
            moveDirection = transform.TransformDirection(moveDirection);
			
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed.Value;
            
        }
        moveDirection.y -= gravity.Value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}