using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioSource soundPlayer;

    public void PlayMusic(AudioClip clip)
    {
        musicPlayer.Stop();
        musicPlayer.clip = clip;
        musicPlayer.loop = true;
        musicPlayer.time = 0;
        musicPlayer.Play();
    }
    public void PlaySound(AudioClip clip)
    {
        soundPlayer.clip = clip;
        soundPlayer.loop = false;
        soundPlayer.Play();
    }
}
