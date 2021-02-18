using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool canBeOpened = false;
    GameObject player;

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player.GetComponent<PlayerStats>().keyFragments >= 4)
        {
            canBeOpened = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(canBeOpened == true)
        {
            player.GetComponent<PlayerStats>().YouWin();
            Debug.Log("DoorOpen");
        }
    }
}
