using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmiror : MonoBehaviour
{
    [SerializeField] Animator animator;
    bool ThrowPunch;
    bool UseRightHand;

    void Update()
    {
        ThrowPunch = Input.GetKey(KeyCode.H);
        animator.SetBool("Crouch_trig", ThrowPunch);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!UseRightHand)
            {
                UseRightHand = true;
            }
            else
            {
                UseRightHand = false;
            }

            animator.SetBool("Crouch_trig", UseRightHand);
        }
    }
}