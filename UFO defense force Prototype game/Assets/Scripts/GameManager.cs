using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public bool isGameOver;
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
            EndGame();
        }
        else  
        {
            gameOverText.gameObject.SetActive(false);
        }
        
    }

    public void EndGame()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
