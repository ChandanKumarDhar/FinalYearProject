using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Audio Sources")]
    public AudioSource backgroundAudio;
    public AudioSource[] audioSource;

    [Header("Audio Clip")]
    public AudioClip[] backgroundClip;
    public AudioClip[] sounds;

    private void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// Set and Play Background Music
    /// </summary>
    /// <param name="_audioClipIndex"></param>
    public void BackgroundAudioFunc(int _audioClipIndex)
    {
        if (backgroundAudio.isPlaying)
        {
            backgroundAudio.Stop();
        }

        backgroundAudio.clip = backgroundClip[0];
        backgroundAudio.Play();
    }

    /// <summary>
    /// Set and play Sounds
    /// </summary>
    /// <param name="_audioSource"></param>
    /// <param name="_audioClipIndex"></param>
    public void AudioChangeFunc(int _audioSource, int _audioClipIndex)
    {
        if (audioSource[_audioSource].isPlaying)
        {
            audioSource[_audioSource].Stop();
        }

        audioSource[_audioSource].clip = sounds[_audioClipIndex];
        audioSource[_audioSource].Play();
    }
}
