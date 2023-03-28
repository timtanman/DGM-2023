using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Bullet : MonoBehaviour
{
    public GameObject pickupEffect;
    public ScoreManager scoreManager;
    public int scoreToGive;

    void Start() {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        
        Destroy(other.gameObject);
        Destroy(gameObject);
        Instantiate(pickupEffect, transform.position, transform.rotation);
        scoreManager.IncreaseScore(scoreToGive);
    }

}
