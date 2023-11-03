using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSoundScript : MonoBehaviour
{
    
        public AudioSource gameOverAudioSource;
        public GameManager isGameOver;
        public void GameOver()
        {
            // Get the AudioSource component from the GAMEOVER object
            gameOverAudioSource = GetComponent<AudioSource>();

            // Check if an AudioSource component exists
            if (gameOverAudioSource != null && isGameOver == true )
            {
                // Play the sound
                Debug.Log("GameOverSoundScriptSoundPlay");
                gameOverAudioSource.Play();
            }
            else
            {
                // Log a message to the console if there is no AudioSource component
                Debug.LogWarning("No AudioSource component found on GAMEOVER object.");
            }
        }
    
}
