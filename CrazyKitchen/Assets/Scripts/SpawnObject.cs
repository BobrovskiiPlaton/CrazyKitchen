using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] prefabs;

    public Vector3 spawnPoint;

    public float spawnInterval = 1f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawnPoint, Quaternion.identity);
            timer = 0;
        }

        
    }
}
