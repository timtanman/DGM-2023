using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_player : MonoBehaviour
{

    public float multiplier = 1.4f;
    public GameManager gameManager;

    void Start() 
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PowerUp"))
            Destroy(other.gameObject);

            else if(other.CompareTag("Enemy"))
            {
                gameManager.isGameOver = true;
                Destroy(gameObject);
                Debug.Log("Game Over");
            }
        }
}
