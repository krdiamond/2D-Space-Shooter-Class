using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{

    private GameObject theShip;
    public float destructionDistance = 500f;

    private float asteroidToShipDistance;

    // Start is called before the first frame update
    void Start()
    {
        theShip = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame 
    void Update()
    {
        if(theShip != null)
        {
            asteroidToShipDistance = Vector2.Distance(transform.position, theShip.transform.position);

            if(asteroidToShipDistance >= destructionDistance)
            {
                Destroy(gameObject); 
            }
        }
    }
}

//ineficient code to spawn and 
