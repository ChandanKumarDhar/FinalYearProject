using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private Animator animator;
    [SerializeField] private Animator optionPanelAnimator;

    public void TurnOffPauseButton()
    {
        AudioManager.Instance.AudioChangeFunc(0, 2);
        Time.timeScale = 0;
        PauseButton.SetActive(false);
        animator.Play("PauseMenu");

    }

    public void Resume()
    {
        AudioManager.Instance.AudioChangeFunc(0, 2);
        animator.Play("PauseMenuOff");
    }

    public void Restart()
    {
        AudioManager.Instance.AudioChangeFunc(0, 2);
        Time.timeScale = 1;
        GameManager.Instance.LoadCurrentLevel();
    }

    public void TurnOnPauseButton()
    {
        Time.timeScale = 1;
        PauseButton.SetActive(true);
    }

    public void OptionButton()
    {
        AudioManager.Instance.AudioChangeFunc(0, 2);
        animator.Play("PauseMenuOffOption");
    }

    public void TurnOnOptionPanel()
    {
        optionPanelAnimator.Play("optionMenuOpen");
    }
}
