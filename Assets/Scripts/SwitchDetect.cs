using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDetect : MonoBehaviour
{
    public bool player_in_range;
    private void Awake()
    {

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
