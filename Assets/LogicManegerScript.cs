using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManegerScript : MonoBehaviour
{
    public int playerScore;
    public int highScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;
    public AudioClip scoreSound;
    public AudioClip gameOverSound;

    void Start()
    {
        //Using player prefs for consistent storage
        highScore = PlayerPrefs.GetInt("Highscore: ",0);
        highScoreText.text = "Highscore: "+ highScore.ToString();

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.volume = 0;
        }
    }

    public void addScore(int scoreToAdd)
    {
        playerScore+= scoreToAdd;
        scoreText.text = playerScore.ToString();
        audioSource.volume = 0.06f;
        PlaySound(scoreSound);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if(playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("Highscore: ",playerScore);
            PlayerPrefs.Save();
        }
        gameOverScreen.SetActive(true);
        audioSource.volume = 0.29f;
        PlaySound(gameOverSound);
    }

    void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip); 
        }
    }
}
