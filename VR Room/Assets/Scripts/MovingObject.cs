using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour, ISpawnable
{
    public float speed;

    public Rigidbody rb;

    private int direction;

    private void Update()
    {
        rb.velocity = transform.right * (speed * direction);
    }

    public void OnSpawn()
    {
        if (transform.position.x > 0)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }
    }
}
