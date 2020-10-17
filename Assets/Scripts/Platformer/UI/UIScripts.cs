using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScripts : MonoBehaviour
{
    [Header("All Text Fields")]
    [SerializeField] private Text lifeText;
    [SerializeField] private Text gemsText;
    [SerializeField] private Text timeText;

    private void Update()
    {
        gemsText.text = PlayerManager.Instance.totalGems.ToString();
        lifeText.text = PlayerManager.Instance.totalLife.ToString();
        timeText.text = ((int)(TimeManager.Instance.TimerTime/60f)).ToString()+ ":" + (TimeManager.Instance.TimerTime%60).ToString("F2");
    }


}
