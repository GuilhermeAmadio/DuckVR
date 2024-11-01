using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnSpawn : MonoBehaviour, ISpawnable
{
    public float jumpForce;

    public Rigidbody rb;

    public void OnSpawn()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
}
