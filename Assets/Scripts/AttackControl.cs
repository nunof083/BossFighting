using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControl : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("isAttacking");
        }
    }
}
