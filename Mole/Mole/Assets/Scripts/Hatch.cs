using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatch : MonoBehaviour {
    public GameObject mole;
    private Transform moleRoot;
	void Start () {
        moleRoot = transform.GetChild(1);
        InvokeRepeating("Create", 0, 2f);
	}
	void Update () {
		
	}

    private void Create()
    {
        GameObject go = Instantiate(mole);
        go.AddComponent<Mole>().GetHole = (HoleNumber)Random.Range(0, 9);
        go.GetComponent<Mole>().GetParent = moleRoot;
        Destroy(go, 5f);
    }






}
