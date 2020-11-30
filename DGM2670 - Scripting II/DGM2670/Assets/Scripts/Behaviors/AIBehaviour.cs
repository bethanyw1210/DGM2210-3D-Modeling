using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIBehaviour : MonoBehaviour
{
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public Transform player;
    private bool canHunt, canPatrol;

    public List<Transform> patrolPoints;
    private int i = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        canPatrol = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = player.position;
        var distance = agent.remainingDistance;
        while (distance <= 1f)
        {
            distance = agent.remainingDistance;
            //yield return wffu;
        }

        //yield return new WaitForSeconds(2f);

        //StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
    }
    
    public void Patrol()
    {
    canPatrol = true;
    while (canPatrol)
    {
        if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
        agent.destination = patrolPoints[i].position;
        i = (i + 1) % patrolPoints.Count;
    }
    }
    
    /*private IEnumerator Patrol()
    {
        canPatrol = true;
        while (canPatrol)
        {
            yield return wffu;
            if (agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }*/
}
