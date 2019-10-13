using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //public CharacterController2D controller;
    public Vector2 movement;
    public Animator anim;
    private Rigidbody2D playerRigidbody;
    public bool moveable = true;

    public float speed = 3f;

    //private float horizontalMove;
    //private float verticalMove;


    void Awake()
    {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;
        //verticalMove = Input.GetAxisRaw("Vertical") * walkSpeed;

        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    void FixedUpdate()
    {
        if (moveable)
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            //controller.Move(horizontalMove * Time.fixedDeltaTime, "h");
            //controllerMove(verticalMove * Time.fixedDeltaTime, "v");
            Animating(h, v);
            Move(h, v);
        }
    }

    void Move(float h, float v)
    {
        movement.Set(h, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(playerRigidbody.position + movement);
    }

    void Animating(float h, float v)
    {
        bool up = false;
        bool down = false;
        bool right = h > 0f;
        bool left = h < 0f;
        //up = v > 0f;
        if (v > 0f)
        {
            up = true;
            down = false;
        } else if (v < 0f)
        {
            up = false;
            down = true;
        }
        //down = v < 0f;
        
        //bool walking = h != 0f || v != 0f;

        anim.SetBool("IsWalkingRight", right);
        anim.SetBool("IsWalkingLeft", left);
        anim.SetBool("IsWalkingUp", up);
        anim.SetBool("IsWalkingDown", down);
        //anim.SetBool("IsWalking", walking);
    }
}
