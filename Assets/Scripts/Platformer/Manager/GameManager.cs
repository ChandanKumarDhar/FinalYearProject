using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Particle Effects")]
    public GameObject GemsParticleEffect;

    private void Awake()
    {
        instance = this;
    }
}
