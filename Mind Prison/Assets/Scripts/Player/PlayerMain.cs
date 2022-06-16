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

    float moveCoff;
    float jumpCoff;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.Find("Sprite").GetComponent<Animator>(); 
        rb2d = GetComponent<Rigidbody2D>(); 
        groundCheck = transform.Find("Check");

        isJumped = false;
        isGrounded = false;
        isGroundedPrev = false;

        moveCoff = 130f;
        jumpCoff = 50f;
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

        Collider2D[] c2ds = Physics2D.OverlapBoxAll(groundCheck.position, new Vector2(2, 0.1f), 0);
        foreach(Collider2D c2d in c2ds)
        {
            if(c2d.gameObject.layer == Layer.Road)
            {
                isGrounded = true;
                break;
            }
        }
    }

    private void CheckIsLanded()
    {
        if (isGrounded == true && isGroundedPrev == false && isJumped == true)
        {
            isJumped = false;

            animator.SetTrigger("Idle");
        }
    }

    private void SetVelocity()
    {
        rb2d.AddForce(new Vector2(xAxis * moveCoff, 0));
        float x = Mathf.Clamp(rb2d.velocity.x, -5, 5);
        float y = Mathf.Clamp(rb2d.velocity.y, -50, 50);

        rb2d.velocity = new Vector2(x, y);
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

            animator.SetBool("IsWalk", false);
        }
        else
        {
            animator.SetBool("IsWalk", true);
        }
    }

    void ActionJump()
    {
        if (Input.GetButtonDown("Jump") == false)
            return;

        if (isJumped == true)
            return;

        isJumped = true;
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpCoff);
        animator.SetTrigger("Jump");
    }
}
