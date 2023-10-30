using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSoundScript : MonoBehaviour
{
    
        private AudioSource gameOverAudioSource;

        void Start()
        {
            // Get the AudioSource component from the GAMEOVER object
            gameOverAudioSource = GetComponent<AudioSource>();

            // Check if an AudioSource component exists
            if (gameOverAudioSource != null)
            {
                // Play the sound
                gameOverAudioSource.Play();
            }
            else
            {
                // Log a message to the console if there is no AudioSource component
                Debug.LogWarning("No AudioSource component found on GAMEOVER object.");
            }
        }
    
}
