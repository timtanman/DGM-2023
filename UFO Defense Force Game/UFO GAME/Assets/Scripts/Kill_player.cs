using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_player : MonoBehaviour
{

    public float multiplier = 1.4f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PowerUp"))
            Destroy(other.gameObject);

            else if(other.CompareTag("Enemy"))
            {
                Destroy(gameObject);
                Time.timeScale = 0; // Stop the game
                Debug.Log("Game Over");
            }
        }
}
