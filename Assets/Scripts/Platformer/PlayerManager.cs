using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject[] players;
    public int totalGems = 0;

    public static PlayerManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
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
