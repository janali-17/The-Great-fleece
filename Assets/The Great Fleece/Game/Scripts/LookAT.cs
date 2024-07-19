using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAT : MonoBehaviour
{
    public Transform lookAt;
    public Transform StartCamera;

    private void Start()
    {
        transform.position = StartCamera.transform.position;
        transform.rotation = StartCamera.transform.rotation;
    }
    void Update()
    {
        transform.LookAt(lookAt);
    }
}
