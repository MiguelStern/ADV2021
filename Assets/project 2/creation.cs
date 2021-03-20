using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creation : MonoBehaviour
{


    [SerializeField] GameObject sphere1;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("createObject", 11.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void createObject() {

        Destroy(sphere1);
        sphere1 = Instantiate(sphere1, new Vector3(1.556f, 0.9f, 1.644f), Quaternion.identity);
        
        Invoke("createObject", 11.5f);
    
    }
}
