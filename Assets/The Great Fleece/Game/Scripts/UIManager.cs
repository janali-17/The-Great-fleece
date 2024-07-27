using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _pausePanel;
    private Animator _animator;

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
    private void Start()
    {
        _animator = GameObject.Find("Pause_Panel").GetComponent<Animator>();
        _animator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Pause();
        }    
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Resume()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    private void Pause()
    {
        _pausePanel.SetActive(true);
        _animator.SetBool("IsPause", true);
        Time.timeScale = 0.0f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
