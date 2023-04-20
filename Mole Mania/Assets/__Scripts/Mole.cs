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
<<<<<<< HEAD
    MoleSpawn moleSpawn; //container for mole spawn script
    private bool isDead = false;
    private Vector3 target;
    private float speed = 5;

    private static int mole = 0;
    private static int bomb = 1;

    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name);
        if (this.gameObject.name == "Mole(Clone)")
        {
            Score.MOLE_HIT(mole);
        }
        else
        {
            Score.MOLE_HIT(bomb);
        }
    }

    void Update()
    {
       if (isDead)
        {
            StartCoroutine(DestroyMole());  
        }
        else
        {
            return;
        }

    }

    IEnumerator DestroyMole()
    {
        for (int x=1; x<= 5; x++)
        {
            target = new Vector3(transform.position.x, (transform.position.y - 5f), transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        yield return new WaitForSeconds(.25f);
        Destroy(gameObject);
    }

}
