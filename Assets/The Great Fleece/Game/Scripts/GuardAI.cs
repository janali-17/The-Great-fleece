using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    // Variables
    public List<Transform> wayPoints;
    [SerializeField]
    private int  _CurrentTarget;


    // Prefabs
    NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        
        
    }

    void Update()
    {
        if (wayPoints.Count > 0 && wayPoints[_CurrentTarget] != null)
        {
            _navMeshAgent.SetDestination(wayPoints[_CurrentTarget].position);
        }
        float distance = Vector3.Distance(transform.position, wayPoints[_CurrentTarget].position);
        if(distance < 1.0f)
        {
            _CurrentTarget++;
        }

        
    }
}
