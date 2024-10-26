using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public Spawner spawner;

    private void Start()
    {
        spawner.StartSpawning();
    }
}
