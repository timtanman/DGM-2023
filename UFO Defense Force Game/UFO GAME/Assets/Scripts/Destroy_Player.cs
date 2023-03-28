using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Player : MonoBehaviour
{

    public GameObject pickupEffect;
    public GameManager gameManager;

    void Start() 
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("PowerUp"))
            {}
            else if (other.CompareTag("Enemy"))
            {
            gameManager.isGameOver = true;
            Destroy(other.gameObject);
            Instantiate(pickupEffect, transform.position, transform.rotation);
            }
        }
}
