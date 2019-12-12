using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject asteroidPrefab;
    private GameObject asteroidClone;

    public float moveSpeed;
    private Vector2 randomDirection;
    private float spawnDelay = 1.0f;
    public float spawnDelayMin = 1.0f;
    public float spawnDelayMax = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
         Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {
        randomDirection = new Vector2(Random.Range(-1.0f,1.0f), Random.Range(-1.0f, 1.0f));
        //Vector2 gives you an X and a Y variable
        //This sets it up by calling a random number between the range

        asteroidClone = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);

        asteroidClone.GetComponent<Rigidbody2D>().velocity = randomDirection * moveSpeed;
        //instead of transform.up random direction is sending the asteroid in a random location

        spawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
        //Sets up

        Invoke("Spawn", spawnDelay);
        //This is a recursive method
        //calls the spawn function in this script after 3seconds
    }
}

//Vector
;