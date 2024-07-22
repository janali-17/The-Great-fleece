using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _voiceOverAudio;
    private static AudioManager _instance;
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("The audio instance is null!");
            }
                return _instance;            
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    public void VoiceOverAudio(AudioClip audioToPlay)
    {
        _voiceOverAudio.clip = audioToPlay;
        _voiceOverAudio.Play();
    }
}
