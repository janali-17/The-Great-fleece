using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("The UI manager instance is Empty");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
