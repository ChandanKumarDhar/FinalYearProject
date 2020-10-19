using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] players;
    public int totalGems = 0;
    public int totalLife = 3;
    public int requiredKey = 1;

    public static PlayerManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CinemachineShake.Instance.ShakeCamera(5f, 1f, 3f);
        AudioManager.Instance.AudioChangeFunc(0, 1);
    }

    private int currentPlayerIndex = 0;

    // Switch Player
    private void SwitchPlayer()
    {
        players[currentPlayerIndex].GetComponent<playerController>().enabled = false;
        currentPlayerIndex++;
        if(currentPlayerIndex >= players.Length)
        {
            currentPlayerIndex = 0;
        }
        players[currentPlayerIndex].GetComponent<playerController>().enabled = true;
    }
}
