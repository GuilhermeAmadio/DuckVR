using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetive : MonoBehaviour
{
    public int scoreValue;

    public string soundToPlay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            ScoreManager.instance.Scored(scoreValue);
            Debug.Log("Scored! " + scoreValue);
            AudioManager.instance.Play(soundToPlay);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("End"))
        {
            Debug.Log("End");
            Destroy(gameObject);
        }
    }
}
