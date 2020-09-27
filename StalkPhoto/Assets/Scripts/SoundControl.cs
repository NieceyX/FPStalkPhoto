using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource walk;
    // Start is called before the first frame update
    void Start()
    {
        walk = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            if (!walk.isPlaying)
            {
                walk.Play();
            }
        }

        else if (Input.GetButton("Horizontal"))
        {
            if (!walk.isPlaying)
            {
                walk.Play();
            }
        }
        else
        {
            walk.Stop();
        }
    }
}
