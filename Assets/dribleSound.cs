using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dribleSound : MonoBehaviour
{
    AudioSource audioSource;
    pickup balle;
    
    // Start is called before the first frame update
    void Start()
    {
        balle = GetComponent<pickup>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(balle.isHolding == true && audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
        else if (balle.isHolding == false && audioSource.isPlaying == true)
        {
            audioSource.Stop();

        }
    }
}
