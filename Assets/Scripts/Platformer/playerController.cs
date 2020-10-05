using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb2d;

    private bool canJump = true;
    private float speed = 5f;
    private float jumpForce = 400f;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") *speed;


        transform.Translate(transform.right * x * Time.deltaTime);

        // Jumping 
        if(Input.GetButtonDown("Jump") && canJump)
        {
            rb2d.AddForce(transform.up * jumpForce);
            canJump = false;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ground")
        {
            canJump = true;
        }

    }

    


}
