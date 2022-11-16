using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXMusic : MonoBehaviour
{
    public AudioSource clickAudioClip;
    
    public void PlayClickClip()
    {
        clickAudioClip.Play();
    }
}
