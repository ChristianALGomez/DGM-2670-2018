using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIAgnent : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform Destination;
    private Transform FinalDestination;
    public Transform PostPoint;
    public FloatDataScript Speed;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = Speed.Value;
        FinalDestination = transform;
    }

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.transform == Destination)
            FinalDestination = Destination;
    }

    private void OnTriggerExit(Collider other)
    {
        FinalDestination = PostPoint;
    }

    private void Update()
    {
        agent.destination = FinalDestination.position;
    }
}
