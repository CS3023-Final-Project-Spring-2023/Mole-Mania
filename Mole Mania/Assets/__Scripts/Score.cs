/*****
 * Created by: Nathan Nguyen
 * Created on: 4/18/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 5/4/2023
 * 
 * Description: Keeps track of current score and sends it to GameManager when level ends.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    static private Score S; // Singleton
    [SerializeField] static private TMPro.TextMeshProUGUI _UI_TEXT;

    [Header("Dynamic")]
    private int score;

    void Awake() {
        S = this;
        _UI_TEXT = GetComponent<TextMeshProUGUI>();
    }

    void Start() {
        score = 0;
    }

    // public method to increase score
    public static void MOLE_HIT(int moleType) {
        // if moleType = mole (0) increase score, else decrease
        S.score = (moleType == 0) ? S.score + 1 : S.score - 2;
        _UI_TEXT.text = "" + S.score;
        GameManager.TRY_SET_HIGH_SCORE(S.score);
    }

    // resets score
    public void RESET_SCORE() {
        score = 0;
    }
}
