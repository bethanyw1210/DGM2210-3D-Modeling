using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIBehaviour : MonoBehaviour
{
    public Transform player;
    public List<Transform> patrolPoints;
    
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private WaitForSeconds wfs = new WaitForSeconds(2f);
    private NavMeshAgent agent;
    private bool canHunt, canPatrol;
    private int i = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = player.position;
        var distance = agent.remainingDistance;

        while (distance <= 1f)
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }

        yield return wfs;

        StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
    }

    private IEnumerator Patrol()
    {
        canPatrol = true;
        
        while (canPatrol)
        {
            yield return wffu;
            
            if(agent.pathPending || !(agent.remainingDistance < 0.5f)) continue;

            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}
