using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //access to text mesh pro libraries

public class ScoreManager : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    public void IncreaseScore(int amount) //this method is called when we need to increase the score by a predetermined amount.
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) //this method is called when we need to decrease the score by a predetermined amount.
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() //This method updates the Score in the HUD
    {
        scoreText.text = "Score: " + score;
    }

}
