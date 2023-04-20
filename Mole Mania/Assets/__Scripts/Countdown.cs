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
        //Countdown_txt.Text = timeleft.ToString();

        if (timeleft <= 0 && isCounting){
            isCounting = false;
        }
     }
}
