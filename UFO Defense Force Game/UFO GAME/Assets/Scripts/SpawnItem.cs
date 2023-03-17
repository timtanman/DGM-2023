using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
 // The item to spawn
    public GameObject Powerup;

    // The time to wait between spawning items
    public float spawnInterval = 10.0f;

    // The timer to keep track of when to spawn the next item
    private float spawnTimer = 0.0f;

    private void Update()
    {
        // Increment the spawn timer
        spawnTimer += Time.deltaTime;

        // Check if it's time to spawn a new item
        if (spawnTimer >= spawnInterval)
        {
            // Reset the timer
            spawnTimer = 0.0f;

            // Spawn the item
            Instantiate(Powerup, transform.position, Quaternion.identity);
        }
    }
}
