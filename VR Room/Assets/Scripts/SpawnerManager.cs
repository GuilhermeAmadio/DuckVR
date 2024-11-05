using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public Spawner spawner;

    public void StartSpawning()
    {
        spawner.StartSpawning();
    }

    public void StopSpawning()
    {
        spawner.StopSpawning();
    }
}
