using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Animator animator;
    private float animConst = 0.02f;
    private CharacterController ch;
    void Start()
    {
        
        animator = GetComponent<Animator>();
        ch = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        ch.Move(Vector3.down * 1.5f * Time.deltaTime);
        if (Input.GetKey(KeyCode.I))
        {
            if (animator.GetFloat("Vertical") < 1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            if (animator.GetFloat("Vertical") > -1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
        }
        else 
        { 

            if(animator.GetFloat("Vertical") > 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            else if (animator.GetFloat("Vertical") < 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);

        }



        if (Input.GetKey(KeyCode.J))
        {
            if (animator.GetFloat("Horizontal") > -1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            if (animator.GetFloat("Horizontal") < 1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
        }
        else
        {

            if (animator.GetFloat("Horizontal") > 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
            else if (animator.GetFloat("Horizontal") < 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);

        }
    }
}
