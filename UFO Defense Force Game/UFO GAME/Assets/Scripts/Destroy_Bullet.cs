using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Bullet : MonoBehaviour
{

    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;


    void Start()
    {
        
    }

    void Awake() {
        //Time.timeScale = 1;
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
            Time.timeScale = 0;
        }
        }
    }
}
