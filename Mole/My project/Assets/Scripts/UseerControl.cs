using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseerControl : MonoBehaviour {
    [SerializeField]
    private List<Mouse> mouse;
    private int tempNumber;
	void Start () {
        mouse = new List<Mouse>();
	}	
	void Update () {
        UseerInput();

    }


    private void UseerInput()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Debug.Log("一号洞出锤");
            GetMouse();
            tempNumber = 0;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Debug.Log("二号洞出锤");
            GetMouse();
            tempNumber = 1;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Debug.Log("三号洞出锤");
            GetMouse();
            tempNumber = 2;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("四号洞出锤");
            GetMouse();
            tempNumber = 3;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Debug.Log("五号洞出锤");
            GetMouse();
            tempNumber = 4;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            Debug.Log("六号洞出锤");
            GetMouse();
            tempNumber = 5;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("七号洞出锤");
            GetMouse();
            tempNumber = 6;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("八号洞出锤");
            GetMouse();
            tempNumber = 7;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("九号洞出锤");
            GetMouse();
            tempNumber = 8;
            Comparison();
        }
    }


    private void GetMouse()
    {
        GameObject[] ms = GameObject.FindGameObjectsWithTag("Mouse");

        foreach (var o in ms)
        {
            if (!mouse.Contains(o.GetComponent<Mouse>()))
            {
                mouse.Add(o.GetComponent<Mouse>());
            }
        }
    }


    private void Comparison()
    {
        if (mouse.Count == 0)
        {
            Debug.Log("没有老鼠可打");
            return;
        }

        foreach (var o in mouse)
        {
            if (tempNumber == (int)o.GetHole)
            {
                mouse.Remove(o);
                Destroy(o.gameObject);
                Debug.Log("干掉了对应位置的老鼠");
                return;
            }

        }



    }







}
