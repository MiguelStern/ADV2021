using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempo : MonoBehaviour
{

    float TargetTime;
    private float StartTime;
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        TargetTime = Time.time - StartTime;
        if (TargetTime == 26.0f) {
            music();
        }
    }

    private void music() {
        source.PlayOneShot(clip);
        
    }
}
