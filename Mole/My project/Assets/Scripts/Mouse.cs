using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HoleNumber//洞号
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
public class Mouse : MonoBehaviour {
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
        gameObject.tag = "Mouse";
        SetPosition(hole);
    }
	void Update () {
		
	}

    private void SetPosition(HoleNumber hole)
    {
        switch (hole)
        {
            case HoleNumber.One:
                tempPos = new Vector3(-247, 52, 0);
                break;
            case HoleNumber.Two:
                tempPos = new Vector3(3, 52, 0);
                break;
            case HoleNumber.Three:
                tempPos = new Vector3(277, 47, 0);
                break;
            case HoleNumber.Four:
                tempPos = new Vector3(-283, -64, 0);
                break;
            case HoleNumber.Five:
                tempPos = new Vector3(10, -64, 0);
                break;
            case HoleNumber.Six:
                tempPos = new Vector3(283, -64, 0);
                break;
            case HoleNumber.Seven:
                tempPos = new Vector3(-294, -186, 0);
                break;
            case HoleNumber.Eight:
                tempPos = new Vector3(11, -193, 0);
                break;
            case HoleNumber.Nine:
                tempPos = new Vector3(312, -196, 0);
                break;
        }
        transform.position = tempPos;
        transform.SetParent(parentTrans, false);
    }







}
