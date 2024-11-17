using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject player1;
    public GameObject player1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public TextMeshProUGUI player1TextTMP;
    public TextMeshProUGUI player2TextTMP;


    private int player1Score;
    private int player2Score;   

    public bool AIGame;


    public int maxScore = 3;

    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void CheckVictory()
    {

        if ((player1Score >= maxScore) && (AIGame))
        {
            SceneManager.LoadScene("VictoryIA");
        }

        else if ((player2Score >= maxScore) && (AIGame))
        {
            SceneManager.LoadScene("VictoryPlayerSingle");
        }

        else if ((player2Score >= maxScore) && (!AIGame))
        {
            SceneManager.LoadScene("VictoryPlayer2");
        }

        else if (player1Score >= maxScore)
        {

            SceneManager.LoadScene("VictoryPlayer1");
        }

        

        else if (player2Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer2");
        }
    }


    public void Player1Scored()
    {
        player1Score++;
        player1TextTMP.text = player1Score.ToString();
        PlayGoalSound();
        CheckVictory();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2TextTMP.text = player2Score.ToString();
        PlayGoalSound();
        CheckVictory();
        ResetPosition();
    }



   private void ResetPosition()
    {
        
            

        if(AIGame)
        {
            ball.GetComponent<Ball>().Reset();
            player2.GetComponent<Players>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }
    }


    private void PlayGoalSound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }










}
