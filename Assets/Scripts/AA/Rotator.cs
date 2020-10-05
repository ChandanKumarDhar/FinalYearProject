using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 90f;

    private void Start()
    {
        HighScore_AA.score = 0;
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime); //Rotating the circle in Z Axis         
    }
}
