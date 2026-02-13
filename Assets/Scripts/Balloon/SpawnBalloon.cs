using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SpawnBalloon : MonoBehaviour
{
    [SerializeField] private List<GameObject> balloons;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private float spawnInterval = 1f;

    private bool canSpawn = true;
    void Update()
    {
        StartCoroutine(SpawnBalloonsCoroutine());
    }

    private IEnumerator SpawnBalloonsCoroutine()
    {
        while (canSpawn)
        {
            spawnBalloons();
            yield return new WaitForSeconds(spawnInterval);
            canSpawn = true;
        }
    }

    private void spawnBalloons()
    {
            int randomBalloonIndex = Random.Range(0, balloons.Count);
            int randomSpawnPointIndex = Random.Range(0, spawnPoints.Count);
            Instantiate(balloons[randomBalloonIndex], spawnPoints[randomSpawnPointIndex].transform.position, Quaternion.identity);
        canSpawn = false;
    }
}
