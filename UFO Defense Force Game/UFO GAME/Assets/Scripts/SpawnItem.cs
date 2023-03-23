using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{

    public GameObject[] ammoPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 18f;
    private float startDelay = 2f;
    private float spawnInterval = 6f;
    
    void Start() 
    {
        InvokeRepeating("SpawnrandomAmmo", startDelay, spawnInterval);
    }

    public void SpawnrandomAmmo()
    {
            Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),1,spawnPosZ);
            int ammoIndex = Random.Range(0,ammoPrefabs.Length);
            Instantiate(ammoPrefabs[ammoIndex],spawnPOs, ammoPrefabs[ammoIndex].transform.rotation);
    }
}