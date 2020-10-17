﻿using System.Collections;
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
    public void BackgroundAudioFunc(int _audioClipIndex, bool _isLoop = true, float _pitch = 1f, float _volume = .25f)
    {
        if (backgroundAudio.isPlaying)
        {
            backgroundAudio.Stop();
        }

        backgroundAudio.pitch = _pitch;
        backgroundAudio.volume = _volume;
        backgroundAudio.loop = _isLoop;
        backgroundAudio.clip = backgroundClip[_audioClipIndex];
        backgroundAudio.Play();
    }

    /// <summary>
    /// Set and play Sounds
    /// </summary>
    /// <param name="_audioSource"></param>
    /// <param name="_audioClipIndex"></param>
    public void AudioChangeFunc(int _audioSource, int _audioClipIndex, bool _isLoop = false, float _pitch = 1f, float _volume = 1f)
    {
        if (audioSource[_audioSource].isPlaying)
        {
            audioSource[_audioSource].Stop();
        }

        audioSource[_audioSource].pitch = _pitch;
        audioSource[_audioSource].volume = _volume;
        audioSource[_audioSource].loop = _isLoop;
        audioSource[_audioSource].clip = sounds[_audioClipIndex];
        audioSource[_audioSource].Play();
    }
}
