using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    

    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 18f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    
    void Start() 
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    void Update()
    {
        
    }

    public void SpawnRandomUFO()
    {
            Vector3 spawnPOs = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),1,spawnPosZ);
            int ufoIndex = Random.Range(0,ufoPrefabs.Length);
            Instantiate(ufoPrefabs[ufoIndex],spawnPOs, ufoPrefabs[ufoIndex].transform.rotation);
    }
}
