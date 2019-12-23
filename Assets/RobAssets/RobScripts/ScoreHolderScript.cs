using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHolderScript : MonoBehaviour
{

    public TextMeshProUGUI scoreTMPro;
    public int currentScore = 8 ;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreTMPro.text = "Score: " + currentScore.ToString();
    }

    public void IncreaseScore()
    {
        currentScore++;
        UpdateUI();
    }
}
             