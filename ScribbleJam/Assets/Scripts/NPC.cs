using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject npcTextInterface;
    public GameObject textBubble;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))        
        {
            
            textBubble.SetActive(false);
            npcTextInterface.SetActive(true);

            
        }
        
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        
        textBubble.SetActive(true);
        npcTextInterface.SetActive(false);
        
    }

}
