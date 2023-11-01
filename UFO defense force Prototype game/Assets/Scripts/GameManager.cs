using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameOverSoundScript GameOver;
    public bool isGameOver;
    public bool gameOverCalled = false;
    private GameObject gameOverText;

    void Awake() 
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");

    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            
            if(gameOverCalled == false) 
            {
                EndGame();
                gameOverCalled = true;
            }
        }
        else  
        {
            gameOverText.gameObject.SetActive(false);
        }
        
    }

    public void EndGame()
    {
        //audioSource.clip = audioClip;
        //audioSource.PlayOneShot();
        GameOver.GameOver();
        Debug.Log("endgamecalled");
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
