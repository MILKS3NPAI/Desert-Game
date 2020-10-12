using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NPC_Interact : MonoBehaviour
{
    private Flowchart myflowchart;
    public int chat_progress = 0;
    public int chat_max = 1;
    public string stringname = "text";
    // Start is called before the first frame update
    void Start()
    {
        myflowchart = FindObjectOfType<Flowchart>();
        chat_progress = myflowchart.GetIntegerVariable("dio_progress");
    }

    // Update is called once per frame
    void Update()
    {
        //if (chat_progress == chat_max + 1)
        //{
        //         myflowchart.StopBlock(stringname + (chat_progress - 1));
        //}
            //if (Input.GetKeyDown(KeyCode.E) && chat_progress == chat_max)
            //{
        
            //    myflowchart.ExecuteBlock(stringname + chat_progress); 
            //    chat_progress += 1;
            //}
            //else if (Input.GetKeyDown(KeyCode.E) && chat_progress < chat_max)
            //{
            //    myflowchart.ExecuteBlock(stringname + chat_progress);
            //    chat_progress += 1;
            //} 
        if (chat_progress >= chat_max)
        {
            chat_progress = chat_max;
        }

        if (!myflowchart.HasExecutingBlocks())
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                myflowchart.ExecuteBlock(stringname + chat_progress);
                chat_progress += 1;
            }
        }
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            myflowchart.SetBooleanVariable("player_in_range", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            myflowchart.SetBooleanVariable("player_in_range", false);
        }
    }
}
