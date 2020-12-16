using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonLaHaut : MonoBehaviour
{
    [SerializeField]
    GameObject ball;



    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = transform.position + transform.forward * 4f;
        Instantiate(ball, position, transform.rotation);

    }
}

    