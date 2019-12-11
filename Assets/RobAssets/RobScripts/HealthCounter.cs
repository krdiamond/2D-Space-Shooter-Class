using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{
    public TextMeshProUGUI healthTMPro;

    public int health;

    private void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void UpdateUI()
    {
        healthTMPro.text = "Health: " + health.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            UpdateUI();

            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
