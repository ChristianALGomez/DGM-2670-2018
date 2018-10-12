using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewMovment", menuName = "Move/EnemyMove")]
public class EnemeyMovePattern : ScriptableObject {
	
	public FloatDataScript gravity;
	public FloatDataScript MoveX, MoveY, MoveZ;
	public FloatDataScript RotX, RotY, RotZ;
	
	protected Vector3 moveDirection;
	private Vector3 rotDirection;
	public bool enabled;

	public virtual void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			Move(transform);
		}

		Move(controller);
	}

	protected void Move(CharacterController controller)
	{
		moveDirection.y -= gravity.Value;
		controller.Move(moveDirection * Time.deltaTime);
	}

	protected void Move(Transform transform)
	{
		moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
		rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
		transform.Rotate(rotDirection);
		moveDirection = transform.TransformDirection(moveDirection);
	}
}