using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseerControl : MonoBehaviour {
    [SerializeField]
    private List<Mole> mole;
    private int tempNumber;
	void Start () {
        mole = new List<Mole>();
	}	
	void Update () {
        UseerInput();

    }


    private void UseerInput()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Debug.Log("No.1 hit");
            GetMole();
            tempNumber = 0;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Debug.Log("No.2 hit");
            GetMole();
            tempNumber = 1;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Debug.Log("No.3 hit");
            GetMole();
            tempNumber = 2;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("No.4 hit");
            GetMole();
            tempNumber = 3;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Debug.Log("No.5 hit");
            GetMole();
            tempNumber = 4;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            Debug.Log("No.6 hit");
            GetMole();
            tempNumber = 5;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("No.7 hit");
            GetMole();
            tempNumber = 6;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("No.8 hit");
            GetMole();
            tempNumber = 7;
            Comparison();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("No.9 hit");
            GetMole();
            tempNumber = 8;
            Comparison();
        }
    }


    private void GetMole()
    {
        GameObject[] ms = GameObject.FindGameObjectsWithTag("Mole");

        foreach (var o in ms)
        {
            if (!mole.Contains(o.GetComponent<Mole>()))
            {
                mole.Add(o.GetComponent<Mole>());
            }
        }
    }


    private void Comparison()
    {
        if (mole.Count == 0)
        {
            Debug.Log("All mole cleared");
            return;
        }

        foreach (var o in mole)
        {
            if (tempNumber == (int)o.GetHole)
            {
                mole.Remove(o);
                Destroy(o.gameObject);
                Debug.Log("Good job");
                return;
            }

        }



    }







}
