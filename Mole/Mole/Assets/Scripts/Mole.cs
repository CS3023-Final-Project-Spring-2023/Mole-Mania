using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HoleNumber// 
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine
}
public class Mole : MonoBehaviour {
    [SerializeField]
    private HoleNumber hole;
    private Vector3 tempPos;
    private Transform parentTrans;

    public HoleNumber GetHole
    {
        set { hole = value; }
        get { return hole;  }
    }

    public Transform GetParent
    {
        set { parentTrans = value; }
        get { return parentTrans;  }
    }
	void Start () {
        gameObject.tag = "Mole";
        SetPosition(hole);
    }
	void Update () {
		
	}

    private void SetPosition(HoleNumber hole)
    {
        switch (hole)
        {
            case HoleNumber.One:
                tempPos = new Vector3(-284, 123, 0);
                break;
            case HoleNumber.Two:
                tempPos = new Vector3(8, 123, 0);
                break;
            case HoleNumber.Three:
                tempPos = new Vector3(292, 121, 0);
                break;
            case HoleNumber.Four:
                tempPos = new Vector3(-309, 15, 0);
                break;
            case HoleNumber.Five:
                tempPos = new Vector3(8, 15, 0);
                break;
            case HoleNumber.Six:
                tempPos = new Vector3(300, 15, 0);
                break;
            case HoleNumber.Seven:
                tempPos = new Vector3(-325, -105, 0);
                break;
            case HoleNumber.Eight:
                tempPos = new Vector3(-2, -110, 0);
                break;
            case HoleNumber.Nine:
                tempPos = new Vector3(326, -110, 0);
                break;
        }
        transform.position = tempPos;
        transform.SetParent(parentTrans, false);
    }







}
