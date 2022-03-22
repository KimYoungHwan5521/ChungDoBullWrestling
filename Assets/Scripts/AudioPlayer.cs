using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource musicPlayer;
    public AudioSource soundPlayer;
    public AudioMixer masterMixer;
    public Slider BGMSlider;
    public Slider SESlider;
    public GameObject BGMOn;
    public GameObject SEOn;

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

    public void AudioControl()
    {
        float BGMVolume = BGMSlider.value;
        float SEVolume = SESlider.value;
        if(BGMVolume == -40) masterMixer.SetFloat("BGM", -80);
        else masterMixer.SetFloat("BGM", BGMVolume);
        if(SEVolume == -40) masterMixer.SetFloat("SE", -80);
        else masterMixer.SetFloat("SE", SEVolume);
    }

    public void OnClickBGMOff()
    {
        masterMixer.SetFloat("BGM", -80);
        BGMOn.SetActive(false);
        BGMSlider.interactable = false;
    }
    public void OnClickBGMOn()
    {
        float BGMVolume = BGMSlider.value;
        BGMOn.SetActive(true);
        BGMSlider.interactable = true;
        masterMixer.SetFloat("BGM", BGMVolume);
    }
    public void OnClickSEOff()
    {
        masterMixer.SetFloat("SE", -80);
        SEOn.SetActive(false);
        SESlider.interactable = false;
    }
    public void OnClickSEOn()
    {
        float SEVolume = SESlider.value;
        SEOn.SetActive(true);
        SESlider.interactable = true;
        masterMixer.SetFloat("SE", SEVolume);
    }
}
