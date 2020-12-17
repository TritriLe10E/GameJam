using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    AudioSource audio;
    [SerializeField]
    AudioClip[] clips;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    [ContextMenu("Test")]
    void PlaySound()
    {
        //renvoie un index aléatoire entre 0 et la taille du tableau
        int indexAleatoire = Random.Range(0, clips.Length);
        audio.PlayOneShot(clips[indexAleatoire]);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlaySound();
        Destroy(gameObject, 9);
    }
}
