using UnityEngine;

public class Tiles : MonoBehaviour
{
    public float tilesSpeed = -.5f;

    private void Update()
    {
        transform.Translate(0f, tilesSpeed * Time.deltaTime, 0f);
    }

}
