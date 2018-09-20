using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class SwitchScripts : MonoBehaviour

{
    public MovePattern Car;
    public MovePattern Plane;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        Car = GetComponent<MovePattern>();
        Plane = GetComponent<MovePattern>();
    }

    void Update()
    {

        if (controller.isGrounded)
        {
           Car.enabled = !Car.enabled;
           Car.Invoke(controller, transform);
        }
        else
        {
            Plane.Invoke(controller, transform);
        }
    }

}
