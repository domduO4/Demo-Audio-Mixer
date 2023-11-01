using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private AudioClip effect;
    [SerializeField] private Slider musicVolume;
    [SerializeField] private Slider effectsVolume;
    private AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();

        float volume;

        audioMixer.GetFloat("MusicVolume", out volume);
        musicVolume.value = volume;

        audioMixer.GetFloat("EffectsVolume", out volume);
        effectsVolume.value = volume;
    }

    public void AjustMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
        Debug.Log("Volume Musique" + volume);
    }
    
    public void AjustEffectsVolume(float volume)
    {
        audioMixer.SetFloat("EffectsVolume", volume);
        Debug.Log("Volume Effets" + volume);
    }

    public void PlaySound()
    {
        source.PlayOneShot(effect);
    }

}