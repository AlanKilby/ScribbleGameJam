using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int playerHP;

    public int keyFragments;

    public GameObject[] hearts;

    public GameObject[] fragments;

    private void Update()
    {
        if(playerHP >= 3)
        {
            playerHP = 3;
            for(int i = 0; i < hearts.Length; i++)
            {
                hearts[i].SetActive(true);
            }

        }
        else if(playerHP == 2)
        {
            hearts[playerHP].SetActive(false);
            hearts[playerHP-1].SetActive(true);
        }
        else if(playerHP == 1)
        {
            hearts[playerHP].SetActive(false);
            hearts[playerHP - 1].SetActive(true);
        }
        else if( playerHP <= 0)
        {
            StartCoroutine("gameOver");
        }

        if(keyFragments > 0)
        {

            fragments[keyFragments - 1].SetActive(true);
        }
    }

    IEnumerator gameOver()
    {

        yield return null;
    }

    public void YouWin()
    {
        StartCoroutine("youWin");
    }
    IEnumerator youWin()
    {
        yield return null;
    }
}
