using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public float minCD, maxCD;

    public Spawner[] spawner;

    private bool canSpawn = true;

    public void StartSpawning()
    {
        StartCoroutine(Spawn());
    }

    public void StopSpawning()
    {
        StopAllCoroutines();
    }

    private IEnumerator Spawn()
    {
        while (canSpawn)
        {
            spawner[Random.Range(0, spawner.Length)].Spawn();

            float randomCD = Random.Range(minCD, maxCD);
            yield return new WaitForSeconds(randomCD);
        }
    }
}
