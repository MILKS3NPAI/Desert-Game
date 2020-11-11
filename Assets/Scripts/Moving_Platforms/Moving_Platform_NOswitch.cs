using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform_NOswitch : MonoBehaviour
{
    private Rigidbody2D body;
    float dirX, movespeed = 4f;
    bool moveRight = true;
    public bool move = false;
    float movement;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (move == false)
        {
            body.velocity = new Vector3(0f, 0f, 0f);
        }   
               if (move == false)
                {
                    move = true;
                }
                else
                {
                    move = false;
                }
            
        


        if (transform.position.x > 4f && move == true)
        {
            moveRight = false;
        }
        if (transform.position.x < -4.5f && move == true)
        {
            moveRight = true;
        }
        if (move == true)
        {


            if (moveRight)
            {
                transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
                
            }
            else
            {
                transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, transform.position.y);
             
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }
}
