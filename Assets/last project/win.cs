using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    string message = "Enorabuena, has encontrado el tesoro";
    private bool truers = false;
    
    public TextMeshPro textos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (truers) textos.SetText(message);
               
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            truers = true;   
        }
    }
    
   
}