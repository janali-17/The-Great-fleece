using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinStateActivation : MonoBehaviour
{
    [SerializeField]
    private GameObject WinCutScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(GameManager.Instance.HasCard == true)
            {
                Debug.Log("End Activate");
                WinCutScene.SetActive(true);
            }
            else
            {
                Debug.Log("You must Have a keyCard!!!");
            }
        }

    }
}
