using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    //Variables
    private bool _coinTossed = false;

    //Prefabs && Handles
    private NavMeshAgent _navMeshAgent;
    [SerializeField]
    private GameObject _CoinPrefab;

    //Animator && Audio
    Animator _animator;
    [SerializeField]
    AudioClip _coinAudio;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {          
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                _navMeshAgent.SetDestination(hitInfo.point);
                _animator.SetBool("Walk",true);
            }
            
        }
       if(_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            _animator.SetBool("Walk", false);
        }
        else
        {
            _animator.SetBool("Walk", true);
        }

       if(Input.GetMouseButtonDown(1) && _coinTossed == false) 
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin,out hitInfo))
            {
                _animator.SetTrigger("Throw");
                _coinTossed = true;
                Instantiate(_CoinPrefab,hitInfo.point, Quaternion.identity);
                AudioSource.PlayClipAtPoint(_coinAudio, transform.position);
                SendAiToCoin(hitInfo.point);
            }

           
        }
    }

    void SendAiToCoin(Vector3 coinPos)
    {
        GameObject[] guards = GameObject.FindGameObjectsWithTag("Guard1"); 
        
        foreach(var guard in guards)
        {
            NavMeshAgent CurrentguardAgent = guard.GetComponent<NavMeshAgent>();
            GuardAI CurrentGuard = guard.GetComponent<GuardAI>();
            Animator animator = guard.GetComponent<Animator>();

            CurrentGuard.coinTossed = true;
            CurrentguardAgent.SetDestination(coinPos);
            animator.SetBool("Walk", true);
            CurrentGuard.coinPos = coinPos;
        }
    }
}
