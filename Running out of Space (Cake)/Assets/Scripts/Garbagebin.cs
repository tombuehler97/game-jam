using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbagebin : MonoBehaviour
{
    private GameObject player;
    public int cooldown;
    private PlayerEconomy playerEconomy;
    public int min, max;
    private float cool;
    private bool playerInRange;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerEconomy = player.GetComponent<PlayerEconomy>();
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
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (Time.time <= cool)
                return;
         
            playerEconomy.ReceiveMoney(Random.Range(min, max));
            cool = Time.time + cooldown;
        }
    }
}
