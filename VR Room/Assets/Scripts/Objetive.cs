using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetive : MonoBehaviour
{
    public int scoreValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            ScoreManager.instance.Scored(scoreValue);
            Destroy(other.gameObject);
            Debug.Log("Score!");
        }
    }
}
