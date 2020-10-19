using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Particle Effects")]
    public GameObject GemsParticleEffect;
    public GameObject KeyParticleEffect;
    public GameObject FallingRocksParticleEffect;

    private void Awake()
    {
        Instance = this;
      //  Time.timeScale = 0;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
