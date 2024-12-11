using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameRestartText;
    public TextMeshProUGUI YouWinText; // Reference to "You Win" text UI
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        GameRestartText.gameObject.SetActive(false); // Ensure Game Restart text is hidden initially
        YouWinText.gameObject.SetActive(false); // Ensure "You Win!" text is hidden initially
    }

    public void UpdateScore(int scoreToAdd)
    {
        // Increase the score
        score += scoreToAdd;
        scoreText.text = "Score = " + score;

        // Cthe score is greater than or equal to 100
        if (score >= 100) 
        {
            DisplayWinText(); //display "You Win!" text
        }
    }

    public void GameOver()
    {
        // Show the Game Over text
        GameRestartText.gameObject.SetActive(true);

        // Hide the "Game Restart" text after a short delay
        StartCoroutine(HideGameRestartText());
    }

    private IEnumerator HideGameRestartText()
    {
        // Wait for 2 seconds and then hide the "Game Restart" text
        yield return new WaitForSeconds(2f);
        GameRestartText.gameObject.SetActive(false);
    }

    public void DisplayWinText()
    {
        // Show the "You Win!" text
        YouWinText.gameObject.SetActive(true);
    }
}

