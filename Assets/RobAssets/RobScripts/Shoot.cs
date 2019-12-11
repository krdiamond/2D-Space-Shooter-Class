using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public float shootSpeed;

    private GameObject projectileClone;
    public Transform projectileLaunchLocation;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            projectileClone = Instantiate(projectile, projectileLaunchLocation.position, transform.rotation);
            projectileClone.GetComponent<Rigidbody2D>().velocity = transform.up * shootSpeed;
        }
    }
}