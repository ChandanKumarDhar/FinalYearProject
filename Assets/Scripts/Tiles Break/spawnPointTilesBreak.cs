using UnityEngine;

public class spawnPointTilesBreak : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject prefab;
    public float spawnTime = 0.5f;
    private float timer;

    private void Start()
    {
        timer = spawnTime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = spawnTime;
            int randomNumber = Random.Range(0, spawnPoints.Length);
            Instantiate(prefab, spawnPoints[randomNumber].position, Quaternion.identity);
        }
    }
}
