/*****
 * Created by: Ryan Pederson
 * Created on: ---
 * 
 * Last edited by: Nathan Nguyen
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
    public GameObject[] spawnLocations;
    public GameObject mole;

    [Header("Inscribed")]
    public GameObject[] moleType;
    public int SpawnTime = 1000;

    private Vector3 respawnLocation;
    private int SpawnTimeCount;
    
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
            SpawnMole();
            SpawnTimeCount = SpawnTime;//resets timer after spawning mole
        }
    }

    public void SpawnMole()
    {
        int spawn = Random.Range(0, spawnLocations.Length);//picks random hole from list
        int type = Random.Range(0, moleType.Length);//picks random mole from array
        mole = Instantiate<GameObject>(moleType[type]);
        Vector3 spawnTransform = spawnLocations[spawn].transform.position;
        mole.transform.position = spawnTransform;//sets mole pos to hole pos
    }
    
}
