using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SpawnBalloon : MonoBehaviour
{
    [SerializeField] private List<GameObject> balloons;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float levelDuration = 1f;


    private bool canSpawn = true;
    public bool levelFinished = false;
    void Update()
    {
        StartCoroutine(SpawnBalloonsCoroutine());
        StartCoroutine(LevelDuration());
    }
    private IEnumerator SpawnBalloonsCoroutine()
    {
        while (canSpawn && !levelFinished)
        {
            spawnBalloons();
            yield return new WaitForSeconds(spawnInterval);
            canSpawn = true;
        }
    }

    private IEnumerator LevelDuration()
    {
        if (!levelFinished)
        {
            yield return new WaitForSeconds(levelDuration);
            Debug.Log("VICTORRYY!!!");
            levelFinished = true;
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
