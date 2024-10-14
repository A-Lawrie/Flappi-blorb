using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LandingManagerScript : MonoBehaviour
{
    public Text HighScoreText;
    public int highScore = 0;
    public AudioSource audioSource;
    public AudioClip landingSound;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore: ",0);
        HighScoreText.text = "Highscore: "+ highScore.ToString();

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
