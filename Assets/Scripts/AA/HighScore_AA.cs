using UnityEngine;
using UnityEngine.UI;

public class HighScore_AA : MonoBehaviour
{
    public static int score = 0;
    public static int pinHitted = 0;

    public Transform color1;
    public Transform color2;
    public Transform color3;
    public Transform color4;

    public Text scoreText;

    private void Update()
    {
        scoreText.text = "HighScore: " + score.ToString();

        if(color1.childCount == 3)
        {
            for(int i = 0; i < color1.childCount; i++)
            {
                Destroy(color1.GetChild(i).gameObject);
            }
            color1.gameObject.SetActive(false);
        }

        if (color2.childCount == 3)
        {
            for (int i = 0; i < color2.childCount; i++)
            {
                Destroy(color2.GetChild(i).gameObject);
            }
            color2.gameObject.SetActive(false);
        }

        if (color3.childCount == 3)
        {
            for (int i = 0; i < color3.childCount; i++)
            {
                Destroy(color3.GetChild(i).gameObject);
            }
            color3.gameObject.SetActive(false);
        }

        if (color4.childCount == 3)
        {
            for (int i = 0; i < color4.childCount; i++)
            {
                Destroy(color4.GetChild(i).gameObject);
            }
            color4.gameObject.SetActive(false);
        }

        if(!color1.gameObject.activeSelf && !color2.gameObject.activeSelf && !color3.gameObject.activeSelf && !color4.gameObject.activeSelf)
        {
            color1.gameObject.SetActive(true);
            color2.gameObject.SetActive(true);
            color3.gameObject.SetActive(true);
            color4.gameObject.SetActive(true);
        }


    }
}
