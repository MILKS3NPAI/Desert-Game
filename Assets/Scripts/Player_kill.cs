using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_kill : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.position = new Vector2(spawnPoint.transform.position.x, spawnPoint.transform.position.y);
        }
    }
}
