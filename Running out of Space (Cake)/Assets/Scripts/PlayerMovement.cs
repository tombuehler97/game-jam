using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //public CharacterController2D controller;
    public Vector2 movement;
    public Animator anim;
    private Rigidbody2D playerRigidbody;

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
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        //controller.Move(horizontalMove * Time.fixedDeltaTime, "h");
        //controllerMove(verticalMove * Time.fixedDeltaTime, "v");
        Move(h, v);
        Animating(h, v);
    }

    void Move(float h, float v)
    {
        movement.Set(h, v);
        //movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(playerRigidbody.position + movement);
    }

    void Animating(float h, float v)
    {
        bool walking = h != 0f || v != 0f;
        anim.SetBool("IsWalking", walking);
    }
}
