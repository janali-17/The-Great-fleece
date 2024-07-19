using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCameras : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverCutScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _gameOverCutScene.SetActive(true);
        }
    }
}
