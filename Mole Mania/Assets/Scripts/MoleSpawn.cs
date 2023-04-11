using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Temporary for testing

public class MoleSpawn : MonoBehaviour
{
    [Header("Dynamic")]
    public GameObject[] spawnLocations;
    public GameObject mole;

    [Header("Inscribed")]
    public GameObject[] moleType;

    private Vector3 respawnLocation;
    
    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("MoleSpawnPoint");
        //builds an aray with all possible spawn locations in the scene
    }

    void Start()
    {
        SpawnMole();
    }

    private void SpawnMole()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        int type = Random.Range(0, moleType.Length);
        mole = Instantiate<GameObject>(moleType[type]);
        Vector3 spawnTransform = spawnLocations[spawn].transform.position;
        spawnTransform.y += 2;
        mole.transform.position = spawnTransform;
        //picks a random hole to spawn the mole at and moves it up
    }
    void Update()//Temporary scene reset for testing
    {
        if (Input.GetButtonDown("Fire1")) //press LCtl
        {
            Debug.Log("Reset");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    
}
