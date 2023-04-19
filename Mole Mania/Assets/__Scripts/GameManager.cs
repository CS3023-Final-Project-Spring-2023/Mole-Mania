/*****
 * Created by: Nathan Nguyen
 * Created on: 4/17/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 4/19/23
 * 
 * Description: Manages scenes, keeps tracks of levels, and helps manage score.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance {
        get {
            if (_instance == null) {
                Debug.LogError("Game Manager is NULL");
            }
            return _instance;
        }
    }

    [Header("Dynamic")]
    public int stage; // current stage selected
     
    void Awake()
    {
        _instance = this;
    }

    // Sets high score for each stage
    public static void TRY_SET_HIGH_SCORE(int scoreToTry) {
        int fetchedScore = -1;
        string key = "HighScore" + Instance.stage; // key = HighScore1, HighScore2, etc.
        if (PlayerPrefs.HasKey(key))
            fetchedScore = PlayerPrefs.GetInt(key);
        if (scoreToTry <= fetchedScore) return;
        PlayerPrefs.SetInt(key, scoreToTry);
    }

    public void TRY_SHOW_HIGH_SCORE() {
        string key = "HighScore" + stage; // key = HighScore1, HighScore2, etc.
        int highScore = 0;
        if (PlayerPrefs.HasKey(key))
            highScore = PlayerPrefs.GetInt(key);
        HighScore.DISPLAY_HIGH_SCORE(highScore);
    }
}
