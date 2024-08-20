using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainHallAudio : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component

    void OnTriggerEnter(Collider other)
    {
        // Check if the player is the one entering the trigger
        if (other.CompareTag("Player"))
        {
            // Play the audio
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}