using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Trigger : MonoBehaviour
{
    [SerializeField] private Door_Trigger door; 
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.E))
      {
        animator.SetBool("Open", true);
      }


      if (Input.GetKeyDown(KeyCode.Q))
      {
         animator.SetBool("Open", false);
      }

  
    }
    
}
