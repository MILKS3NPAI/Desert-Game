using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDetect : MonoBehaviour
{
    public bool player_in_range;
    [SerializeField]
    public Animator button_anim;
    private void Awake()
    {
        //button_anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && player_in_range == true)
        {
            if (button_anim.GetBool("button_on") == false)
            {
                button_anim.SetBool("button_on", true);
            }
            else if (button_anim.GetBool("button_on") == true)
            {
                button_anim.SetBool("button_on", false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player_in_range = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player_in_range = false;
        }
    }
}
