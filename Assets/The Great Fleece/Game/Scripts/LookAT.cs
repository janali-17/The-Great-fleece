using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAT : MonoBehaviour
{
    public Transform lookAt;
    void Update()
    {
        transform.LookAt(lookAt);
    }
}
