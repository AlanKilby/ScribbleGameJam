using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionScript : MonoBehaviour
{

    public void RightAnswer()
    {
        PlayerStats playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        playerStats.playerHP++;
        playerStats.keyFragments++;
        
    }

    public void WrongAnswer()
    {
        PlayerStats playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        playerStats.playerHP--;

    }
}
