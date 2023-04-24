/*****
 * Created by: Nathan Nguyen
 * Created on: 4/17/23
 * 
 * Last edited by: Ryan Pederson
 * Last edited on: 4/21/23
 * 
 * Description: If mole's collider is clicked, increase the score. Handles movement and life timer of mole.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{

    private bool isDead = false; //bool for calling when to remove mole
    private Vector3 target; //movement target for up and down movement
    private float speed = 5; //movement speed for up and down movements
    private int life = 1000; //Time before mole dies naturally
    private bool inPos = false; //bool to get mole to proper vitical pos on spawn

    private static int mole = 0;
    private static int bomb = 1;

    void Start()
    {
        StartCoroutine(RiseUpMole());
        
    }

    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name);
        isDead = true;
        if (this.gameObject.name == "Mole(Clone)")
        {
            Score.MOLE_HIT(mole);
        }
        else
        {
            Score.MOLE_HIT(bomb);
        }
    }

    void FixedUpdate()
    {
        if (inPos == false)
        {
            StartCoroutine(RiseUpMole());
        }
        life--;
        if (life <= 0)
        {
            isDead = true;
        }
       if (isDead)
        {
            StartCoroutine(DestroyMole());
        }

    }

    IEnumerator RiseUpMole()
    {
        Debug.Log("Up");
        // original:  (transform.position.y + .0175f)
        target = new Vector3(transform.position.x, (transform.position.y + .15f), transform.position.z);
        for (int x = 1; x <= 2; x++)//animates movement from original pos to new pos
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        yield return new WaitForSeconds(.2f);
        transform.position = target;
        inPos = true;
    }

    IEnumerator DestroyMole()
    {
        for (int x=1; x<= 5; x++)//animates movement from original pos to new pos
        {
            target = new Vector3(transform.position.x, (transform.position.y - 5f), transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        yield return new WaitForSeconds(.25f);
        Destroy(gameObject); //destroys mole object after moving underground        
    }

}
