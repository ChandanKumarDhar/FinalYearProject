using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private Animator animator;


    public void TurnOffPauseButton()
    {
        Time.timeScale = 0;
        PauseButton.SetActive(false);
        animator.Play("PauseMenu");

    }

    public void Resume()
    {
        animator.Play("PauseMenuOff");
    }

    public void Restart()
    {
        GameManager.Instance.LoadCurrentLevel();
    }

    public void TurnOnPauseButton()
    {
        Time.timeScale = 1;
        PauseButton.SetActive(true);
        
    }
}
