using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionScript : MonoBehaviour
{
    public Text questionText;
    public string newQuestion;
    public GameObject rightAnswer;
    public GameObject[] wrongAnswers;
    public void RightAnswer()
    {
        PlayerStats playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        playerStats.playerHP++;
        playerStats.keyFragments++;

        Destroy(rightAnswer);
        for(int i = 0; i < wrongAnswers.Length; i++)
        {
            Destroy(wrongAnswers[i]);
        }

        questionText.text = newQuestion;
        
    }

    public void WrongAnswer()
    {
        PlayerStats playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        playerStats.playerHP--;

    }
}
