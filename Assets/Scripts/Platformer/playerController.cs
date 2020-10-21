using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    [SerializeField] float dieEffectsDuration = 5f;

    Rigidbody2D rb2d;

    private bool canJump = true;
    private float speed = 5f;
    private float jumpForce = 400f;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        TimeManager.Instance.StartTimer();
        AudioManager.Instance.BackgroundAudioFunc(0);
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

        if(collision.transform.tag == "Enemy")
        {
            PlayerManager.Instance.totalLife--;
            if (PlayerManager.Instance.totalLife > 0)
            {
                CinemachineShake.Instance.ShakeCamera(5f, 1f);
                AudioManager.Instance.AudioChangeFunc(0, 1);
            }
            else
            {
                AudioManager.Instance.BackgroundAudioFunc(1, false);
                Destroy(Instantiate(GameManager.Instance.PlayerDieParticleEffect, this.transform.position, this.transform.rotation), dieEffectsDuration);
                Destroy(this.gameObject);
            }
        }

    }

    


}
