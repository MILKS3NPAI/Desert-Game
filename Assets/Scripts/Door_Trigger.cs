using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Trigger : MonoBehaviour
{
    [SerializeField]
    private SwitchDetect switch_detect = null;
    public static Animator dooranimator;
    public AudioSource sound;
    private void Awake()
    {
        dooranimator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }
    private void Update()
    {

      if (switch_detect.player_in_range == true)
      { 
        if (Input.GetKeyDown(KeyCode.E))
        {
                if(dooranimator.GetBool("Open") == false)
                {
                    dooranimator.SetBool("Open", true);
                    sound.Play();
                }
               
        }
      }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (dooranimator.GetBool("Open") == true)
            {
                dooranimator.SetBool("Open", false);
            }
        }
    }  
}
