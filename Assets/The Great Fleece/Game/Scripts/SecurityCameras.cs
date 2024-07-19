using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCameras : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverCutScene;
    public Material RedMat;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            transform.GetComponent<Renderer>().material = RedMat;
            GetComponentInParent<Animator>().enabled = false;
            StartCoroutine(WaitForAnim());
        }
    }
    IEnumerator WaitForAnim()
    {
        yield return new WaitForSeconds(1.5f);
        _gameOverCutScene.SetActive(true);
    }
}
