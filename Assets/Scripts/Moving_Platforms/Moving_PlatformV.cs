using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_PlatformV : MonoBehaviour
{
    private Rigidbody2D body;
    public float dirY, movespeed = 4f;
    public float max;
    public float min;
    bool moveUp = true;
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




        if (transform.position.y > max && move == true)
        {
            moveUp = false;
        }
        if (transform.position.y < min && move == true)
        {
            moveUp = true;
        }
        if (move == true)
        {


            if (moveUp)
            {
                transform.position = new Vector2(transform.position.x , transform.position.y + movespeed * Time.deltaTime);

            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - movespeed * Time.deltaTime);

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
