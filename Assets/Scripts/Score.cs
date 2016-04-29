using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    public static int SCORE = 0;
    string highscoreKey = "highscore";
    public Text currentScore;
    public Text HighScore;
    // Use this for initialization

    
    void Start () {
        if (SceneManager.GetActiveScene().name.Equals("Gameplay"))
        {
            SCORE = 0;
        }else if (SceneManager.GetActiveScene().name.Equals("GameOver"))
        {
            
            SetHighscore();
            showHighscore();
        }
        else if (SceneManager.GetActiveScene().name.Equals("HighScore"))
        {

            showHighscore();
        }
    }




    void SetHighscore()
    {

        if (!PlayerPrefs.HasKey(highscoreKey))
            PlayerPrefs.SetInt(highscoreKey, SCORE);


        if (PlayerPrefs.GetInt(highscoreKey) < SCORE)
        {
            PlayerPrefs.SetInt(highscoreKey, SCORE);
        }
        
        PlayerPrefs.Save();

    }


    void showHighscore()
    {
        if (!PlayerPrefs.HasKey(highscoreKey))
            PlayerPrefs.SetInt(highscoreKey, SCORE);
        print(PlayerPrefs.GetInt(highscoreKey));
        HighScore.text = ""+PlayerPrefs.GetInt(highscoreKey);
    }
    void showScore()
    {
        currentScore.text = "" + SCORE;
    }
	// Update is called once per frame
	void Update () {
        showScore();
        
    }
}
