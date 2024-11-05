using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minCD, maxCD;

    public Transform[] pos;

    public GameObject[] objectToSpawn;

    private bool canSpawn;

    public void StartSpawning()
    {
        canSpawn = true;
        StartCoroutine(Spawn());
    }

    public void StopSpawning()
    {
        canSpawn = false;
        StopCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (canSpawn)
        {
            Transform randomPos = pos[Random.Range(0, pos.Length)];

            GameObject randomObj = objectToSpawn[Random.Range(0, objectToSpawn.Length)];

            GameObject spawnedObj = Instantiate(randomObj, randomPos.position, Quaternion.identity);
            spawnedObj.GetComponent<ISpawnable>().OnSpawn();

            float randomCD = Random.Range(minCD, maxCD);
            yield return new WaitForSeconds(randomCD);
        }
    }
} 
