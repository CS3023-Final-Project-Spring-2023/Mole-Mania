/*****
 * Created by: Nathan Nguyen
 * Created on: 4/18/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 4/18/23
 * 
 * Description: Keeps track of current score and sends it to GameManager when level ends.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;

    void Start() {
        score = 0;
    }

    // public method to increase score
    public void moleHit() {
        score++;
    }

    // resets score
    public void resetScore() {
        score = 0;
    }
}
