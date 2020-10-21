using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChecker : MonoBehaviour
{
    [SerializeField] private Animator wallBarrierAnimator;

    private bool alreadyHitted = false;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (PlayerManager.Instance.requiredKey <= 0 && !alreadyHitted)
            {
                alreadyHitted = true;
                wallBarrierAnimator.Play("wallBarrier");
                AudioManager.Instance.AudioChangeFunc(0, 1);
                Destroy(Instantiate(GameManager.Instance.FallingRocksParticleEffect, this.transform.position, this.transform.rotation), 5f);
                CinemachineShake.Instance.ShakeCamera(5f, 1f);
            }
            else
            {
                Debug.Log("Key Needed to unlock the door........");
            }
        }
    }
}
