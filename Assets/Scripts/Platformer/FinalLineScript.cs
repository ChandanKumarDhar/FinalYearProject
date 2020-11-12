using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLineScript : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] private Animator otherAnimator;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            TimeManager.Instance.PauseTimer();
            otherAnimator.Play("PauseMenu");
            col.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
