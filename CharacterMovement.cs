using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{   
    private Rigidbody2D theRB;
    public float movespeed;
    public float jumpForce = 2.0f;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal")* movespeed, theRB.velocity.y);

        

        if (Input.GetButtonDown("Jump") || Input.GetKeyDown("space") )
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        };
        if (Input.GetButtonUp("Jump") && theRB.velocity.y > 0  || Input.GetKeyUp("space") && theRB.velocity.y > 0)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, theRB.velocity.y* -5f);
        }

    }
}
