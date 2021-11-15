using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingController : MonoBehaviour
{
    //speed and movement
    public float speed = 5f;
    public float jumpSpeed = 5f;
    private float movement = 0f;
    //Checks if king is on ground
    private Rigidbody2D kingBody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    //King is only effected by collisions in the groundLayer
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private Animator kingAnimation;
    // Start is called before the first frame update
    void Start()
    {
        kingBody = GetComponent<Rigidbody2D> ();
        kingAnimation = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        //determines if king is on ground
        isTouchingGround = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, groundLayer);

        movement = Input.GetAxis("Horizontal");

        //movement controls
        if(movement > 0f){
            kingBody.velocity = new Vector2  (movement * speed, kingBody.velocity.y);
        }
        else if(movement < 0f){
               kingBody.velocity = new Vector2  (movement * speed, kingBody.velocity.y);
        }
        else{
            kingBody.velocity = new Vector2 (0,kingBody.velocity.y);
        }
        
        //jump control
        if(Input.GetButtonDown ("Jump") && isTouchingGround){
            kingBody.velocity = new Vector2 (kingBody.velocity.x,jumpSpeed);
        }

        //aniamtion script
        kingAnimation.SetFloat("Speed",kingBody.velocity.x);
        kingAnimation.SetBool("OnGround", isTouchingGround);
        
    }
}
