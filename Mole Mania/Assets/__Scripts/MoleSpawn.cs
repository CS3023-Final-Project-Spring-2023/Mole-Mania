/*****
 * Created by: Ryan Pederson
 * Created on: ---
 * 
 * Last edited by: Ryan Pederson
 * Last edited on: 4/23/2023
 * 
 * Description: Simple script to spawn in 1 mole in existing holes.
 *****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoleSpawn : MonoBehaviour
{
    [Header("Dynamic")]
    public GameObject[] spawnLocations; //Array of all possible locations, dynamic will change upon running
    public GameObject mole; //The current type of mole selected to spawn
    public GameObject[] LastLocations; //Last locations a mole was spawned in, CHANGE IN INSPECTIOR TO MATCH #OF SPAWNS FOR EACH BOARD!!

    [Header("Inscribed")]
    public GameObject[] moleType;
    public int SpawnTime = 1000;

    private int SpawnTimeCount; //Countdown time to change how fast moles spawn
    private int LastLocIndex = 0; //A number for counting through the last location to assign the next index
    private bool SpawnOpen = true; //Tells if the check to see if the hole is already occupied passed or failed
    
    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("MoleSpawnPoint");
        //builds an aray with all possible spawn locations in the scene
    }

    void Start()
    {
        //SpawnMole();
        SpawnTimeCount = SpawnTime;//initialises the timer
    }

    void FixedUpdate()
    {
        SpawnTimeCount --;//counts down to spawn another mole
        if (SpawnTimeCount <= 0)
        {
            Debug.Log("Spawning Mole");
            SpawnMole();
            SpawnTimeCount = SpawnTime;//resets timer after spawning mole
        }
    }

    public void SpawnMole()
    {
        int spawn = Random.Range(0, spawnLocations.Length);//picks random hole from list
        int type = Random.Range(0, moleType.Length);//picks random mole from array
        
        foreach (GameObject x in LastLocations) //checks to see if generated number is in last used locations
        {
            if(spawnLocations[spawn] == x)
            {
                SpawnOpen = false;//there is already a mole in the hole
            }
        }
        if (SpawnOpen)//if no mole in selected hole
        {
            mole = Instantiate<GameObject>(moleType[type]);//spawn mole
            Vector3 spawnTransform = spawnLocations[spawn].transform.position;
            mole.transform.position = spawnTransform;//sets mole pos to hole pos

            if (LastLocIndex < 5)//adds current location to next spot in lastLoc index
            {
                LastLocations[LastLocIndex] = spawnLocations[spawn];
                LastLocIndex += 1;
            }
            else//resets index number to start array again
            {
                LastLocIndex = 0;
                LastLocations[LastLocIndex] = spawnLocations[spawn];
            }
        }
        else//mole currently in hole, set ability to spawn to true again, and recall spawn function
        {
            SpawnOpen = true;
            SpawnMole();
        }
        
    }
    
}
