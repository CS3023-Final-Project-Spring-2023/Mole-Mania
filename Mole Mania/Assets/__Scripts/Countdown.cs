/*****
 * Created by: Zhiyuan
 * Created on: ---
 * 
 * Last edited by: Nathan Nguyen
 * Last edited on: 5/4/2023
 * 
 * Description: Tracks level timer.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
public float timeleft;
public Text Countdown_txt;
private bool isCounting;

    // Start is called before the first frame update
    void Start()
    {
     isCounting = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting){
            timeleft -= Time.deltaTime;
        }

        Countdown_txt.text = timeleft.ToString("0");

        if (timeleft <= 0 && isCounting){
            isCounting = false;
            GameManager.SWITCH_TO_END_SCENE();
        }
     }
}
