using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    // Variables
    public List<Transform> wayPoints;
    public Transform CurrentTarget;

    // Prefabs
    NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        
        if(wayPoints.Count > 0)
        {
            if(wayPoints[0] != null)
            {
                CurrentTarget = wayPoints[0];
            }
        }
    }

    void Update()
    {
        _navMeshAgent.destination = CurrentTarget.position;
        
    }
}
