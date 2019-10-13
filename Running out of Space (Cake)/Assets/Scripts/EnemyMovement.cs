using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Animator anim;
    Transform player;
    public int triggerDistance;
    public float chaseingSpeed;
    private float speed;
    public float xAxis;
    public float yAxis;
    private bool isMoving;
    private Rigidbody2D enemyRigidbody;
    public Vector2 direction;
    void Move(Vector2 direction)
    {
        direction = direction.normalized * speed * Time.deltaTime;
        enemyRigidbody.MovePosition(enemyRigidbody.position + direction);
    }

    // Update is called once per frame


    private void Awake()
    {
        //xaxis y axis

        anim = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        AnimateEnemy();

        if (Vector2.Distance(player.position, this.transform.position) < triggerDistance)
        {
            direction = player.position - this.transform.position;

            if (direction.magnitude >= 1)
            {
                speed = chaseingSpeed;
                //this.transform.Translate(0, 0, 0.5f);
                Move(direction);
                isMoving = true;
                //speed = chaseingSpeed;
            }
            else if (isMoving && direction.magnitude < 1)
            {
                //Debug.Log("magnitude <2");
                isMoving = false;
                speed = 0;
                //Move(new Vector2(0, 0));
                //Vector2 moveBack=
            }
            
        }
        else
        {
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false);
        }

    }


    void AnimateEnemy()
    {
        bool right = direction.x > 0;
        bool left = direction.x < 0;
        bool up = direction.y > 0;
        bool down = direction.y < 0;


        
            anim.SetBool("IsWalkingRight", right);
            anim.SetBool("IsWalkingLeft", left);

        
         if ((up || down) && !left && !right )
        {
            anim.SetBool("IsWalkingRight", true);
            anim.SetBool("IsWalkingLeft", false);
        }
        else
        {
          /*  anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false);
            */
        }


    }
}
//retreat funktion
//urpsrungs position speichern
