using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            source.Play();
        }
        else if(!Input.GetKey(KeyCode.W))
        {
            source.Stop();
        }
    }
}
