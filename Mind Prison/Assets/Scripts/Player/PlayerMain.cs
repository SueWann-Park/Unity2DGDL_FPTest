using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator animator;
    private float xAxis;
    private bool isJumped;
    private bool isGrounded;
    private bool isGroundedPrev;
    private Transform groundCheck;

    float moveCoff = 130;
    float jumpCoff = 6.5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = /***************** TO BE FILLED ****************/
        rb2d = /***************** TO BE FILLED ****************/
        groundCheck = /***************** TO BE FILLED ****************/

        Jump = false;
        isGrounded = false;
        isGroundedPrev = false;
    }

    // Update is called once per frame
    void Update()
    {
        ActionMove();
        ActionJump();
    }

    private void FixedUpdate()
    {
        SetLocalScale();
        SetVelocity();
        CheckIsGrounded();
        CheckIsLanded();
    }

    private void CheckIsGrounded()
    {
        isGroundedPrev = isGrounded;
        isGrounded = false;
        
        Collider2D[] c2ds = Physics2D.OverlapBoxAll(/****** TO BE FILLED ******/, new Vector2(2, 0.1f), 0);
        foreach(Collider2D c2d in c2ds)
        {
            if(c2d.gameObject.layer == Layer.Road)
            {
                /***************** TO BE FILLED ****************/
                /***************** TO BE FILLED ****************/
            }
        }
    }

    private void CheckIsLanded()
    {
        if ()
        {
            Jump = false;

            animator./***************** TO BE FILLED ****************/
        }
    }

    private void SetVelocity()
    {
        float x = Mathf.Clamp(xAxis * moveCoff, -5, 5);
        float y = Mathf.Clamp(rb2d.velocity.y, -10, 10);

        /***************** TO BE FILLED ****************/
    }


    private void SetLocalScale()
    {
        if (xAxis == 0)
            return;

        transform.localScale = new Vector3(xAxis > 0 ? 1 : -1, 1, 1);
    }

    void ActionMove()
    {
        xAxis = Input.GetAxis("Horizontal");
        if (Mathf.Abs(xAxis) < 0.1f)
        {
            xAxis = 0;

            animator./***************** TO BE FILLED ****************/
        }
        else
        {
            animator./***************** TO BE FILLED ****************/
        }
    }

    void ActionJump()
    {
        if (Input.GetButtonDown("Jump") == false)
            return;

        if (isJumped == true)
            return;

        isJumped = /***************** TO BE FILLED ****************/
        rb2d.velocity = /***************** TO BE FILLED ****************/

        animator./***************** TO BE FILLED ****************/
    }
}
