﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabKeyCardActivation : MonoBehaviour
{
    [SerializeField]
    private GameObject GrabCutScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GrabCutScene.SetActive(true);
        }
    }
}
