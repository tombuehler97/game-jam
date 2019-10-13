using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mail : MonoBehaviour
{
    private GameObject player;

    private PlayerEconomy playerEconomy;

    private bool playerInRange;
    // Start is called before the first frame update
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
    // Update is called once per frame
    void Update()
    {
        if (playerInRange && Input.GetKey(KeyCode.E))
        {
            playerEconomy.StoreCakes();
        }
    }
}
