using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject restartButton;

    public GameObject youWinImage;

    public int scoreNeededToWin = 10;

    private GameObject theShip;

    private ScoreHolderScript scoreHolderRef;

    public GameObject asteroidSpawnerParent;

    private GameObject[] asteroidsToBeDestroyed;
    // [] - defines this as an array instead of a regular game object

    // Start is called before the first frame update
    void Awake()
    {
        scoreHolderRef = GetComponent<ScoreHolderScript>();
        theShip = GameObject.FindWithTag("Player");
        restartButton.SetActive(false);
        youWinImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(theShip == null)
        {
            EndGame();
            ShowRestartButton();

        }
        if(scoreHolderRef.currentScore >= scoreNeededToWin)
        {
            youWinImage.SetActive(true);
            EndGame();
            Invoke("ShowRestartButton", 3f);
            //invoke allows you to input a time as a perameter 
        }
    }

    void EndGame()
    {
        Destroy(asteroidSpawnerParent);
        asteroidsToBeDestroyed = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < asteroidsToBeDestroyed.Length; i++)
        {
            Destroy(asteroidsToBeDestroyed[i]);
        }

    }

    void ShowRestartButton()
    {
        restartButton.SetActive(true);
    }
}
