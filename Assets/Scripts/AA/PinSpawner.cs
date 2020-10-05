using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject pinPrefab;

    public static bool isPinShooted = false;
    public static bool isGameOver = false;
    public static int pinValue = 0;

    public float nextPinSpawnTime = 0.5f;

    private float timer;

    private void Start()
    {
        timer = nextPinSpawnTime;
    }

    private void Update()
    {
        if (isPinShooted)
        {
            timer -= Time.deltaTime;  //Reduicng Time with Time.deltaTime
            if (timer <= 0)
            {
                Instantiate(pinPrefab, transform.position, Quaternion.identity);
                timer = nextPinSpawnTime;
                isPinShooted = false;
            }
        }
    }

}
