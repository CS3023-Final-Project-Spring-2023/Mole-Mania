using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
public float timeleft;
public Text Countdown_txt;
private bool isCounting;
public GameObject GameOverPanel;


    // Start is called before the first frame update
    void Start()
    {
     isCounting = true;   
     GameOverPanel.SetActive(false);
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
            ShowGameOver();
        }
     }

     void ShowGameOver(){
        GameOverPanel.SetActive(true);
     }
}
