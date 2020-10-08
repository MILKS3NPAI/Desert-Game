using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Trigger : MonoBehaviour
{
    [SerializeField]
    private SwitchDetect switch_detect = null;
    public static Animator dooranimator;
    private void Awake()
    {
        dooranimator = GetComponent<Animator>();

    }
    private void Update()
    {

      if (switch_detect.player_in_range == true)
      { 
        if (Input.GetKeyDown(KeyCode.E))
        {
                dooranimator.SetBool("Open", true);
        }
      }

      if (Input.GetKeyDown(KeyCode.Q))
      {
         dooranimator.SetBool("Open", false);
      }
    }  
}
