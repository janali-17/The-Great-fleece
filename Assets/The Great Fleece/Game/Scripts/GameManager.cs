using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _IntroCutScene;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get { 
            if (_instance == null)
            {
                Debug.LogError("The Instance is Null!!!");
            }
            
            return _instance;
        }
    }

    public bool HasCard
    {
        get;
        set;
    }

    private void Awake()
    {
        _instance = this;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) 
        {
            _IntroCutScene.time = 60.0f;
        }
    }
}
