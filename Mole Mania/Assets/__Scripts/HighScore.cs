/*****
 * Created by: Nathan Nguyen
 * Created on: 4/18/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 5/4/2023
 * 
 * Description: Manages the display of the high score (text).
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScore : MonoBehaviour
{
    private static HighScore HS; // singleton
    [SerializeField] static private TMPro.TextMeshProUGUI _UI_TEXT;

    void Awake() {
        _UI_TEXT = GetComponent<TextMeshProUGUI>();
        HS = this;
        if (SceneManager.GetActiveScene().name == "End Screen") { 
            _UI_TEXT.text = "High Score: " + PlayerPrefs.GetInt("LastSceneScore");
        }
    }

    public static void DISPLAY_HIGH_SCORE(int score) {
        _UI_TEXT.text = "" + score;
    }

    public static void CONVENIENT_RESTART() {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
