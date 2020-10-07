using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpspeed;
    public bool isGrounded = false;
    private Rigidbody2D body;
  
    void Start()
    {
        
        
    }
    private void Update()
    {
        Jump();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * movespeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            GetComponent<Player_Controls>().isGrounded = true;
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            GetComponent<Player_Controls>().isGrounded = false;
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpspeed), ForceMode2D.Impulse);
        }
        
    }
    
}
