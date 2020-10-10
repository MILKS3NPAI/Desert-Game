using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Player_Controls : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D body;
    private BoxCollider2D boxCollider2d;
    public Fungus.Flowchart myFlowchart;
    private float movespeed = 7f;
    private float jumpspeed = 65f;
    private float movement;
    public bool player_in_dialogue;
  
    void Start()
    {
        myFlowchart = FindObjectOfType<Flowchart>();
        body = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        player_in_dialogue = myFlowchart.GetBooleanVariable("player_in_chat");
        if (player_in_dialogue == false)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        if (player_in_dialogue == false)
        {
            movement = Input.GetAxis("Horizontal") * movespeed;
            body.velocity = new Vector3(movement, body.velocity.y, 0f);
        }
    }
   

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            body.AddForce(new Vector2(0f, jumpspeed), ForceMode2D.Impulse);
        }
        
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }

    void IfHit()
    {

    }

}
