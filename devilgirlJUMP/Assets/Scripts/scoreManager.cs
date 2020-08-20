using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int score;

    [SerializeField]
    public Text scoreDisplay, loseScore, winScore, loseGrade, winGrade;

    public playerController playerController;

    [SerializeField]
    public GameObject winScreen, loseScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {        
        scoreDisplay.text = score.ToString();
        loseScore.text = score.ToString();
        winScore.text = score.ToString();

        if (playerController.health == 0)
        {
            loseScreen.SetActive(true);
            Time.timeScale = 0;
            
            if (score >= 3)
            {
                loseGrade.text = "C";
            }

            if (score >= 4)
            {
                loseGrade.text = "B";
            }

            if (score >= 6)
            {
                loseGrade.text = "A";
            }
        }
        Debug.Log (playerController.health);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("harmful"))
        {
            //increase score
            score++;
            Debug.Log(score);
        }

        if (other.CompareTag("goal"))
        {
            Goal();

        }
       
    }

    public void Goal()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;

        if (score >= 3)
        {
            winGrade.text = "C";
        }

        if (score >= 4)
        {
            winGrade.text = "B";
        }

        if (score >= 6)
        {
            winGrade.text = "A";
        }
    }
}
