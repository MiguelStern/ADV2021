using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moverAI : MonoBehaviour
{
    
    NavMeshAgent agent;
    Animator animatorPersonaje;
    public Transform MarcaDestino;
    public Camera camara;
    private bool isJumping = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animatorPersonaje = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Ray ray = camara.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit)) {

                agent.destination = MarcaDestino.position = hit.point;
                
            }

        }

        if (agent.isOnOffMeshLink && !isJumping)
        {
            animatorPersonaje.SetTrigger("Jumping");
            isJumping = true;
        }
        else if (!agent.isOnOffMeshLink) {

            isJumping = false;

        }

        animatorPersonaje.SetFloat("Horizontal", transform.InverseTransformDirection(agent.velocity).x);
        animatorPersonaje.SetFloat("Vertical", transform.InverseTransformDirection(agent.velocity).z);
    }
}
