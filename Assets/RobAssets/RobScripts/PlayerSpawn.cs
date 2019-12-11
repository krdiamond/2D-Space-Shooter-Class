using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private Vector3 spawnPosition;

    public GameObject spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            // transform.position = spawnPosition;
            transform.position = spawnLocation.transform.position;
        }
    }
}
