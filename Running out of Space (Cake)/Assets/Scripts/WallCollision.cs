using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private GameObject player;
    private Transform stopMovement;
    Rigidbody2D playerBody;
    PlayerMovement pMove;
    private Collider other;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("xD");
         if (collision.gameObject.tag =="Player" )
         {
            //other = collision.collider;
            player = GameObject.FindGameObjectWithTag("Player");

            //playerBody = player.GetComponent < Rigidbody2D >();
            // playerBody.velocity = Vector2.zero;
            pMove = player.GetComponent<PlayerMovement>();
            pMove.movement = Vector2.zero;
        }
         
    }


    bool isTrigger = false;
    Vector2 collissionMovement;
    private void FixedUpdate()
    {
        while (isTrigger)
        {
            if (pMove.movement.x == 0)
            {

            }
        }
    }
    /*void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("xD1");
        //Debug.Log(other.name);
        if (other.tag == "Player")
            {

            Debug.Log("xD2");
            player = GameObject.FindGameObjectWithTag("Player");

                //playerBody = player.GetComponent < Rigidbody2D >();
               // playerBody.velocity = Vector2.zero;
                pMove = player.GetComponent<PlayerMovement>();
                
                //pMove.movement = new Vector2 (0,0);
                pMove.speed = 0;
                collissionMovement = pMove.movement;

            }*/
            

        //Player zurücksetzen um 1 pixel

    



}

