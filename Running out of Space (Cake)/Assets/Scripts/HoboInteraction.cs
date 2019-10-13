using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoboInteraction : MonoBehaviour
{
    
    private bool playerInRange;
    private GameObject player;
    public int cooldown;
    private float cool = 0;
    public Animator anim;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
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
        if (Time.time > cool)
        {
            if (playerInRange && player.GetComponent<PlayerEconomy>().currentMoney > 0)
            {
                player.GetComponent<PlayerEconomy>().currentMoney = 0;
                //GetComponent<EnemyMovement>().retreat();
            }
            else if (playerInRange && player.GetComponent<PlayerEconomy>().currentMoney <= 0)
            {
                player.GetComponent<PlayerMovement>().moveable = false;
                if (anim.GetBool("IsWalkingRight")) anim.SetBool("IsStabbingRight", true);
                else if (anim.GetBool("IsWalkingLeft")) anim.SetBool("IsStabbingLeft", true);
                anim.SetBool("IsWalkingRight", false);
                anim.SetBool("IsWalkingLeft", false);
            }
            cool = Time.time + (float)cooldown;
        }
    }
}
