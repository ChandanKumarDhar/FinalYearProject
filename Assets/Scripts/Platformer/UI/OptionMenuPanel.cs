using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenuPanel : MonoBehaviour
{
    [Header("Animators")]
    [SerializeField] private Animator optionMenuAnimator;
    [SerializeField] private Animator pauseMenuAnimator;

    [Header("Volume Bars")]
    [SerializeField] private Image musicVolumeBar;
    [SerializeField] private Image soundVolumeBar;

    private void Start()
    {
        musicVolumeBar.fillAmount = AudioManager.Instance.backgroundAudio.volume;
        soundVolumeBar.fillAmount = AudioManager.Instance.audioSource[0].volume;
    }

    public void BackButton()
    {
        AudioManager.Instance.AudioChangeFunc(0, 2);
        optionMenuAnimator.Play("optionMenuClosed");
    }

    public void OptionMenuPanelAnimationOFF()
    {
        pauseMenuAnimator.Play("PauseMenu");
    }

    public void MusicVolumeIncreseButton()
    {
        AudioManager.Instance.MusicVolumeIncrese();
        AudioManager.Instance.AudioChangeFunc(0, 2);
        musicVolumeBar.fillAmount = AudioManager.Instance.backgroundAudio.volume;
    }

    public void MusicVolumeDecreseButton()
    {
        AudioManager.Instance.MusicVolumeDecrese();
        AudioManager.Instance.AudioChangeFunc(0, 2);
        musicVolumeBar.fillAmount = AudioManager.Instance.backgroundAudio.volume;
    }

    public void SoundVolumeIncreseButton()
    {
        AudioManager.Instance.SoundVolumeIncrese();
        AudioManager.Instance.AudioChangeFunc(0, 2);
        soundVolumeBar.fillAmount = AudioManager.Instance.audioSource[0].volume;
    }

    public void SoundVolumeDecreseButton()
    {
        AudioManager.Instance.SoundVolumeDecrese();
        AudioManager.Instance.AudioChangeFunc(0, 2);
        soundVolumeBar.fillAmount = AudioManager.Instance.audioSource[0].volume;
    }
}
