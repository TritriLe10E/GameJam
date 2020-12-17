using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonLaHaut : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    static float currentX = -6f;
    public static int nombreBallon;
    
    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = new Vector3(currentX, 18f, 0.16f);
        Instantiate(ball, position, transform.rotation);
        Destroy(other.gameObject);
        currentX += 3f;
        nombreBallon++;
    }



}

    