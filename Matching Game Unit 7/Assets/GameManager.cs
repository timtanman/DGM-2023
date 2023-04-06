using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject gameOverText;
    public AudioClip endGameSound;

    private AudioSource audioSource;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = endGameSound;
        audioSource.playOnAwake = false; // disable auto-play
        gameOverText = GameObject.Find("GameOverText");

        if (gameOverText == null)
        {
            Debug.LogError("Could not find 'GameOverText' GameObject.");
        }
        else
        {
            gameOverText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        if (gameOverText != null)
        {
            gameOverText.SetActive(true);
        }
        audioSource.Play();
        Time.timeScale = 0;
    }
}
