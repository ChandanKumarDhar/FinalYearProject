using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLevelTittleScript : MonoBehaviour
{
    [SerializeField] private GameObject PauseButton;

    public void TurnOnGame()
    {
        PauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
}
