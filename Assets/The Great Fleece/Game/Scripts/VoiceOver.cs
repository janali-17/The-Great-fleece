using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOver : MonoBehaviour
{
    private bool _hasPlayed = false;
    [SerializeField]
    AudioClip Coin_voiceClip;

    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player" && _hasPlayed == false)
            {
            AudioManager.Instance.VoiceOverAudio(Coin_voiceClip);
            _hasPlayed = true;
            }
    }
}
