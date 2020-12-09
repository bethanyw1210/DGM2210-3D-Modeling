using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehaviour : MonoBehaviour
{
    public Transform player;
    public FloatData playerHealth;
    
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private WaitForSeconds wfs = new WaitForSeconds(2f);
    private NavMeshAgent agent;
    private int i = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        agent.destination = player.position;
        var distance = agent.remainingDistance;

        while (distance <= 1f && (playerHealth.value > 0))
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }
        yield return wfs;
    }
}
