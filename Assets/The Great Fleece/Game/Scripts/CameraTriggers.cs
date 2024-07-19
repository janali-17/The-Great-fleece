using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour
{
    //Variable
    [SerializeField]
    private Transform _camAngle;



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Camera.main.transform.position = _camAngle.transform.position;
            Camera.main.transform.rotation = _camAngle.transform.rotation;
        }
    }


}
