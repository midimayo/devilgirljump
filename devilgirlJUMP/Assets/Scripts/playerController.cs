using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour { 
    
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidbody;

    public bool onGround;
    private bool canJump;
    public LayerMask setGround;

    private Collider2D myCollider;

    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onGround = myCollider.IsTouchingLayers(setGround);
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if (onGround == true)
        {
            canJump = true;
        }
        //Check if the player is on the ground. If we are, then we are able to jump.
        onGround = true;
        print("on the ground");

        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        }
        else
        {
            canJump = false;
        }
    }
}
