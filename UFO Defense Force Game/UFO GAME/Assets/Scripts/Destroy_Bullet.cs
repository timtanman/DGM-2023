using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Bullet : MonoBehaviour
{

    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    private GameManager gameManager;


    void Start()
    {
         gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Awake() {
    }


    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);

        }
        
        if(transform.position.z < lowerBounds)
        {
            if(gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            gameManager.isGameOver = true;
        }
        }
    }
}
