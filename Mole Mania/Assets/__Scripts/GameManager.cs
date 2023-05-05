/*****
 * Created by: Nathan Nguyen
 * Created on: 4/17/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 5/4/2023
 * 
 * Description: Manages scenes, keeps tracks of levels, and helps manage score.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager manager {
        get {
            if (_instance == null) {
                Debug.LogError("Game Manager is NULL");
            }
            return _instance;
        }
    }


    // The following code allows you to easily reset the PlayerPrefs HighScore
    [Tooltip("Check this box to reset the HighScore in PlayerPrefs")]
    public bool resetHighScoreNow = false;

    [Header("Dynamic")]
    public int stageNum; // current stage selected\

    private string key;
    static private int _SCORE = 0;
     
    void Awake()
    {
        _instance = this;
        stageNum = SceneManager.GetActiveScene().buildIndex;
        /* key relative to current stage
        *  key = HighScore1, HighScore2, etc; value = high score integer
        */
        key = "HighScore" + stageNum; 

        if(resetHighScoreNow) {
            resetHighScoreNow = false;
            PlayerPrefs.SetInt(key , 0);
            Debug.Log("PlayPrefs HighScore reset to 0");
        }
    }

    void Start() {
        if (PlayerPrefs.HasKey(key))
            SCORE = PlayerPrefs.GetInt(key);
        PlayerPrefs.SetInt(key, SCORE);
        showHighScore();
    }

    static public int SCORE {
        get{return _SCORE;}
        private set {
            _SCORE = value;
        }
    }

    // Sets high score for each stage
    public static void TRY_SET_HIGH_SCORE(int scoreToTry) {
        int fetchedScore = -1;
        if (PlayerPrefs.HasKey(manager.key))
            fetchedScore = PlayerPrefs.GetInt(manager.key);
        if (scoreToTry <= fetchedScore) return; // check if new score is higher than old score
        /*  If new scoreToTry is a new high score:
                Store it in PlayerPrefs      
                Set SCORE to scoreToTry
                Display the new high score
        */
        PlayerPrefs.SetInt(manager.key, scoreToTry);
        SCORE = scoreToTry;
        manager.showHighScore();
    }

    // invokes a method in HighScore to show the high score in GUI
    void showHighScore() {
        HighScore.DISPLAY_HIGH_SCORE(SCORE);
    }

    public static void SWITCH_TO_END_SCENE() {
        PlayerPrefs.SetInt("LastSceneScore", SCORE);
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-1, LoadSceneMode.Single);
    }
}
