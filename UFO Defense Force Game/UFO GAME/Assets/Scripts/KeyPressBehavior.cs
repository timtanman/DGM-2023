using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPressBehavior : MonoBehaviour
{
    public UnityEvent onKeyPress;
    public AudioClip keyPressSound;
    private AudioSource audioSource;


    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = keyPressSound;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onKeyPress.Invoke();
            PlayKeyPressSound();
        }
    }

        void PlayKeyPressSound()
    {
        audioSource.Play();
    }
}
