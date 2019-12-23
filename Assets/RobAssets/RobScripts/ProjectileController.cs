using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    private ScoreHolderScript scoreHolderRef;

    //public Sprite explosionAsteroid;

    private void Awake()
    {
        scoreHolderRef = GameObject.FindWithTag("GameController").GetComponent<ScoreHolderScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            scoreHolderRef.IncreaseScore();
            //Increases score

            Destroy(collision.gameObject);
            // Destroys the actual asteroid

            Destroy(gameObject);
            // Destroys laser projecti

        }

        //if (collision.gameObject.tag == "Enemy")
        //{
        //    scoreHolderRef.IncreaseScore();
        //    //Increases score

        //    Destroy(collision.gameObject, 1f);

        //    collision.gameObject.GetComponent<Collider2D>().enabled = false;
        //    collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        //    collision.gameObject.GetComponent<SpriteRenderer>().sprite = explosionAsteroid;
        //    // Destroys the actual asteroid

        //    Destroy(gameObject);
        //    // Destroys laser projectile
        //}
    }
}
