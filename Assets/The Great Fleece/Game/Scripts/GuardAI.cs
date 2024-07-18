using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    // Variables
    public List<Transform> wayPoints;
    [SerializeField]
    private int _CurrentTarget;
    private bool _reverse = false;
    private bool _targetReached = false;


    // Components handles
    NavMeshAgent _navMeshAgent;

    // Animator
    Animator _animator;
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();


    }

    void Update()
    {
        if (wayPoints.Count > 0 && wayPoints[_CurrentTarget] != null)
        {
            _navMeshAgent.SetDestination(wayPoints[_CurrentTarget].position);
        }
        float distance = Vector3.Distance(transform.position, wayPoints[_CurrentTarget].position);
        if(distance < 1 && (_CurrentTarget == 0 || _CurrentTarget == wayPoints.Count -1))
        {
            _animator.SetBool("Walk", false);
        }
        else
        {
            _animator.SetBool("Walk", true);
        }
        if (distance < 1.0f && _targetReached == false)
        {
            _targetReached = true;
            Debug.Log("Target Has Been Reached " + _targetReached);

            StartCoroutine(WaitForNextPoint());
        }
    }

    IEnumerator WaitForNextPoint()
    {
        Debug.Log("wait for 5 seconds");
        float randRang = UnityEngine.Random.Range(5.0f, 7.0f);
        if(_CurrentTarget == 0)
        {
            yield return new WaitForSeconds(randRang);
        }
        else if(_CurrentTarget == wayPoints.Count - 1)
        {
            yield return new WaitForSeconds(randRang);
        }


        if (_reverse == true)
        {
            _CurrentTarget--;
            if (_CurrentTarget == 0)
            {
                _reverse = false;
                _CurrentTarget = 0;
            }
        }
        else
        {
            _CurrentTarget++;
        }

        if (_CurrentTarget == wayPoints.Count)
        {
            _reverse = true;
            _CurrentTarget--;
        }

        _targetReached = false;
    }

}