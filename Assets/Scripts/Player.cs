using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    public float jump = 2f;
    public Animator animator;
    Rigidbody2D rb;
    bool facingRight;
    public int health;
    public int score;
    public Text text;

    private void OnCollisionEnter2D(Collision2D other)
    {
        string tag = other.collider.tag;
        if (tag == "Obstacle")
        {
            health--;
        }
        else if (tag == "Score")
        {
            score++;
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        //initialize 
        facingRight = true;
        rb = this.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Movement(horizontal);
        Flip(horizontal);
        animator.SetFloat("jump", Input.GetAxis("Vertical"));
        text.text = score.ToString();

    }

    //movement
    void Movement(float horizontal)
    {
        //horizontal movement
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        //makes player jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && (rb.velocity.y!=0))
        {
            rb.AddForce(new Vector2(0, 3), ForceMode2D.Impulse);
           
            

        }
        
        
    }

    //change direction 
    void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 face = transform.localScale;
            //change
            face.x *= -1;
            transform.localScale = face;
        }
    }


   
}
