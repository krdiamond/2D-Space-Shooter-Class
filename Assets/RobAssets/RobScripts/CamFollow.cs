using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private GameObject theShip;

    private float camToShipDistance;

    // Start is called before the first frame update
    void Start()
    {
            theShip = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (theShip == null)
        {
            theShip = GameObject.FindWithTag("Player");
        }

        if (theShip != null)
        {
            camToShipDistance = Vector2.Distance(transform.position, theShip.transform.position);
            // print("My distance is " + camToShipDistance);

            transform.position = Vector2.Lerp(transform.position, theShip.transform.position, camToShipDistance * Time.deltaTime);
        }
    }
}
