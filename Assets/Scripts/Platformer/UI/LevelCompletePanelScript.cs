using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompletePanelScript : MonoBehaviour
{
    [Header("All the Text")]
    [SerializeField] private Text scoreText;
    [SerializeField] private Text gemsText;
    [SerializeField] private Text timeText;

    int score = 0;

    [Header("Animator")]
    [SerializeField] private Animator otherAnimator;

    private void Update()
    {
        score = (int)((PlayerManager.Instance.totalGems * 100) + (100000 / (TimeManager.Instance.TimerTime/10)));
        scoreText.text = "S C O R E : " + score;
        gemsText.text = "G E M S : " + PlayerManager.Instance.totalGems;
        timeText.text = "T I M E : " + UIScripts.Instance.timeText.text;
    }

    public void OK()
    {
        if(score > PlayerPrefs.GetInt("HighScore3"))
        {
            PlayerPrefs.SetInt("HighScore3", score);
            if(score > PlayerPrefs.GetInt("HighScore2"))
            {
                PlayerPrefs.SetInt("HighScore3", PlayerPrefs.GetInt("HighScore2"));
                PlayerPrefs.SetInt("HighScore2",score);
                if (score > PlayerPrefs.GetInt("HighScore1"))
                {
                    PlayerPrefs.SetInt("HighScore2", PlayerPrefs.GetInt("HighScore1"));
                    PlayerPrefs.SetInt("HighScore1", score);
                }
            }
        }

        otherAnimator.Play("PauseMenu");
        this.gameObject.SetActive(false);
    }

}
