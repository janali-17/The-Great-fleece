﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    [SerializeField]
    private GameObject _GameOverCut;

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _GameOverCut.SetActive(true);
        }
    }
}
