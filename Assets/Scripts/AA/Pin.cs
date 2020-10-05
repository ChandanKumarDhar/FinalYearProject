using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public SpriteRenderer sr;

    public Color[] pinColor;

    private string pinTag;

    public float pinSpeed = 100f;

    private void Start()
    {
        //int index = Random.Range(0, pinColor.Length);   // Take Random Number

        int index = PinSpawner.pinValue % 4;
        PinSpawner.pinValue++;

        sr.color = pinColor[index];     // Set radnom color to the pin

        if (index == 0)
        {
            pinTag = "Color1";
        }
        else if(index == 1)
        {
            pinTag = "Color2";
        }
        else if (index == 2)
        {
            pinTag = "Color3";
        }
        else
        {
            pinTag = "Color4";
        }

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))    //Press Space to shoot Pin
        {
            rb2d.velocity = new Vector2(0f, pinSpeed) * Time.fixedDeltaTime;

            PinSpawner.isPinShooted = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != null)
        {
            rb2d.velocity = new Vector2(0f, 0f);

            if (col.tag == pinTag)
            {
                transform.parent = col.transform;
                HighScore_AA.score += 10;
                HighScore_AA.pinHitted++;
            }

            else
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Destroy(col.transform.parent.gameObject);
            }

            this.enabled = false;
        }
    }

}
