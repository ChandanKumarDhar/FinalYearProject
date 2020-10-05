using UnityEngine;
using UnityEngine.UI;

public class HighScore_TilesBreak : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.text = "HighScore: " + score.ToString();
    }

}
