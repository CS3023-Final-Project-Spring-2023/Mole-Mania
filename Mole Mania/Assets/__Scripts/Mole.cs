/*****
 * Created by: Nathan Nguyen
 * Created on: 4/17/23
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 4/19/23
 * 
 * Description: If mole's collider is clicked, increase the score.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    // if mole is shot (collider is clicked)
    void OnMouseDown() {
        Debug.Log("Mole hit");
        Score.MOLE_HIT();
    }
}
