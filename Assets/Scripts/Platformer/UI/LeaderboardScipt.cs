using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardScipt : MonoBehaviour
{
    [Header("All Text")]
    [SerializeField] private Text HighScore1;
    [SerializeField] private Text HighScore2;
    [SerializeField] private Text HighScore3;

    private void Update()
    {
        HighScore1.text = PlayerPrefs.GetInt("HighScore1").ToString();
        HighScore2.text = PlayerPrefs.GetInt("HighScore2").ToString();
        HighScore3.text = PlayerPrefs.GetInt("HighScore3").ToString();
    }

    public void OK()
    {
        GameManager.Instance.LoadNextLevel();
    }
}
