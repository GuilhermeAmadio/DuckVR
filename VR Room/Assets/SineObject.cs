using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineObject : MonoBehaviour
{
    public float speed, amplitude;

    private void Update()
    {
        var YOffset = new Vector3(0f, Mathf.Sin(Time.time * speed) * amplitude + amplitude, 0f); 
        transform.position = new Vector3(transform.position.x, YOffset.y, transform.position.z);
    }
}
