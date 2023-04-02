using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Bullet : MonoBehaviour
{
    public GameObject pickupEffect;
    public ScoreManager scoreManager;
    public int scoreToGive;
    public AudioClip keyPressSound;

    void Start() {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        gameObject.SetActive(false);
        Instantiate(pickupEffect, transform.position, transform.rotation);
        scoreManager.IncreaseScore(scoreToGive);
        
        PlayKeyPressSound();
    }
            
    void PlayKeyPressSound()
    {
        AudioSource.PlayClipAtPoint(keyPressSound, transform.position);
        Debug.Log("WORK");
    }
}