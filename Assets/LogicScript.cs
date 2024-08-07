using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")] //Menu for testing purposes
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString(); //converting the value and adding it to text
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backToMenu() {

        SceneManager.LoadScene(0);
    }

    public void gameOver() //sets active the game over screen
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
