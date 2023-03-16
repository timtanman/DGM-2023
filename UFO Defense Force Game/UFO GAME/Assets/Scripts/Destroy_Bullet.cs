using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Bullet : MonoBehaviour
{

    public float topBounds = 30.0f;
    public float lowerBounds = -25.0f;


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
        else if(transform.position.z < lowerBounds)
        {
        }
    }
}
