 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float x;
    private float y;
    private Animator animator;
    private SpriteRenderer sprite;
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private float jump = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        Debug.Log(y);
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        rb.velocity= new Vector2(x * speed,rb.velocity.y);

        AnimationState();

        checkIfFall();

    }

    private void AnimationState()
    {
        if (x > 0)
        {
            animator.SetBool("Running", true);
            sprite.flipX = false;
        }
        else if (x < 0)
        {
            animator.SetBool("Running", true);
            sprite.flipX = true;
        }
        else
        {
            animator.SetBool("Running", false);
            
        }

        if (y != 0)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
    }

    private void checkIfFall()
    {
        if (transform.position.y < -2)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
