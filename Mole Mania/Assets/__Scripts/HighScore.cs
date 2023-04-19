/*****
 * Created by: Nathan Nguyen
 * Created on: 4/18/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 4/19/23
 * 
 * Description: Shows high score when stage is picked.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    private static HighScore HS; // singleton
    [SerializeField]
    static private TMPro.TextMeshProUGUI _UI_TEXT;
    
    void Awake() {
        _UI_TEXT = GetComponent<TextMeshProUGUI>();
        HS = this;
    }

    public static void DISPLAY_HIGH_SCORE(int score) {
        _UI_TEXT.text = "High \nScore: " + score;
    }
}
