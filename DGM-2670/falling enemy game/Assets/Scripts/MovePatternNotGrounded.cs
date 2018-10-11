using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Move/MovePatternNotGrounded")]
public class MovePatternNotGrounded : MovePattern
{


    public override void Invoke(CharacterController controller, Transform transform)
    {
        Move(transform);
        Move(controller);
    }
}