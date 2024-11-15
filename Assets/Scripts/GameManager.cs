using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        //Update score by 5 every time 
    }

    public void UpdateScore(int scoreToAdd){
        //increase the score
        score += scoreToAdd;
        //print it as score increases
        scoreText.text = "Score = " + score;
    }
    
    public void GameOver(){
             //Game over text appear
        gameOverText.gameObject.SetActive(true);
    }

}
