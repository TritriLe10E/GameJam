using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonLaHaut : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    


    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = new Vector3(-6f, 18f, 0.16f);
        Instantiate(ball, position, transform.rotation);

    }

    private void Update()
    {
        
    }
}

    