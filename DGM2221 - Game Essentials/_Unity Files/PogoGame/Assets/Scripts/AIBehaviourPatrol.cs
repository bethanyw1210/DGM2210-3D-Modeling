using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIBehaviourPatrol : MonoBehaviour
{
    public Transform player;
    public List<Transform> patrolPoints;
    public bool canPatrol = true;
    public FloatData playerHealth;

    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private WaitForSeconds wfs = new WaitForSeconds(2f);
    private NavMeshAgent agent;
    private bool canHunt;
    private int i = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = player.position;
        var distance = agent.remainingDistance;

        while (distance <= 1f && (playerHealth.value > 0))
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
