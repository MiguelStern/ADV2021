using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ControlAnimaciones : MonoBehaviour
{
    public Animator animator;
    public string parametrosBoolean;
    bool b = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            b = !b;
            animator.SetBool(parametrosBoolean, b);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) animator.SetTrigger("destruir");
    }
}
