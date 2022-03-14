using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioSource soundPlayer;

    public void PlayMusic(AudioClip clip, bool loop = true)
    {
        musicPlayer.Stop();
        musicPlayer.clip = clip;
        musicPlayer.loop = loop;
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
