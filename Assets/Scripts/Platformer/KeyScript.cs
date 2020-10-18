using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private Image keyUI;
    [SerializeField] float effectsDuration = 5f;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            PlayerManager.Instance.requiredKey--;
            keyUI.color = new Color(keyUI.color.r, keyUI.color.g, keyUI.color.b,255f);
            AudioManager.Instance.AudioChangeFunc(0, 0);
            Destroy(Instantiate(GameManager.Instance.GemsParticleEffect, this.transform.position, this.transform.rotation), effectsDuration);
            Destroy(this.gameObject);
        }
    }
}
