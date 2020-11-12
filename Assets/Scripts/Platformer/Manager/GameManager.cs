using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Particle Effects")]
    public GameObject GemsParticleEffect;
    public GameObject PlayerDieParticleEffect;
    public GameObject KeyParticleEffect;
    public GameObject FallingRocksParticleEffect;

    [Header("Game Over Panel")]
    public GameObject GameOverPanel;
    public GameObject PauseButton;

    private void Awake()
    {
        Instance = this;
        //  Time.timeScale = 0;
        if (!PlayerPrefs.HasKey("HighScore1"))
        {
            PlayerPrefs.SetInt("HighScore1", 20000);
            PlayerPrefs.SetInt("HighScore2", 10000);
            PlayerPrefs.SetInt("HighScore3", 5000);
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Application.Quit();
    }
}
