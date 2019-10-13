using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    private bool playerInRange;
    private GameObject player;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            playerInRange = true;
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (playerInRange && player.GetComponent<PlayerEconomy>().currentCakes > 0)
        {
            player.GetComponent<PlayerMovement>().speed = 0f;
        }
    }
}
