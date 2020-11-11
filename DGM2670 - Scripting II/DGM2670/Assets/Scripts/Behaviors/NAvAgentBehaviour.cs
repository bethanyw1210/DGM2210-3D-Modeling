using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NAvAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform destination;
    public GameAction gameActionObj;
    private Transform triggeredTransform;

    private void Start()
    {
        triggeredTransform = transform;
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
        gameActionObj.transformAction += HandleTransfrom;
    }

    public void HandleTransfrom(Transform obj)
    {
        if (triggeredTransform == obj)
        {
            destination = obj;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggeredTransform = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    private void Update()
    {
        agent.destination = destination.position;
    }
}
