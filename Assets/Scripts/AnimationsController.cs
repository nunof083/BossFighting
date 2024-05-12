using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("w") && Input.GetKey("a"))
        {
            animator.SetBool("isWalkingLeft", true);
        }
        else
        {
            animator.SetBool("isWalkingLeft", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            animator.SetBool("isWalkingRight", true);
        }
        else
        {
            animator.SetBool("isWalkingRight", false);
        }

        /////////////////////////////////////////////////////

        if (Input.GetKey("a"))
        {
            animator.SetBool("isLeft", true);
        }
        else
        {
            animator.SetBool("isLeft", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("d"))
        {
            animator.SetBool("isRight", true);
        }
        else
        {
            animator.SetBool("isRight", false);
        }

        /////////////////////////////////////////////////////

        if (Input.GetKey("w") && Input.GetKey("left shift"))
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        ////////////////////////////////////////////////////


        if (Input.GetKey("w") && Input.GetKey("a") && Input.GetKey("left shift"))
        {
            animator.SetBool("isRunningLeft", true);
        }
        else
        {
            animator.SetBool("isRunningLeft", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("w") && Input.GetKey("d") && Input.GetKey("left shift"))
        {
            animator.SetBool("isRunningRight", true);
        }
        else
        {
            animator.SetBool("isRunningRight", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("w") && Input.GetButtonDown("Jump"))
        {
            animator.SetBool("isJumpRunning", true);
        }
        else
        {
            animator.SetBool("isJumpRunning", false);
        }

        ////////////////////////////////////////////////////
        
        if (Input.GetKey("w") && Input.GetKey("a") && Input.GetButtonDown("Jump"))
        {
            animator.SetBool("isJumpRunningLeft", true);
        }
        else
        {
            animator.SetBool("isJumpRunningLeft", false);
        }

        ////////////////////////////////////////////////////
        
        if (Input.GetKey("w") && Input.GetKey("d") && Input.GetButtonDown("Jump"))
        {
            animator.SetBool("isJumpRunningRight", true);
        }
        else
        {
            animator.SetBool("isJumpRunningRight", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("s"))
        {
            animator.SetBool("isBackward", true);
        }
        else
        {
            animator.SetBool("isBackward", false);
        }

        //////////////////////////////////////////////////// ROLLING

        if (Input.GetKey("w") && Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("isRollingForward", true);
        }
        else
        {
            animator.SetBool("isRollingForward", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("s") && Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("isRollingBackward", true);
        }
        else
        {
            animator.SetBool("isRollingBackward", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("s") && Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("isRollingBackward", true);
        }
        else
        {
            animator.SetBool("isRollingBackward", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("a") && Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("isRollingWalkLeft", true);
        }
        else
        {
            animator.SetBool("isRollingWalkLeft", false);
        }

        ////////////////////////////////////////////////////

        if (Input.GetKey("d") && Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("isRollingWalkRight", true);
        }
        else
        {
            animator.SetBool("isRollingWalkRight", false);
        }

        ////////////////////////////////////////////////////
    }
}
