using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonLaHaut : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    [SerializeField]
    Transform maisonTransform;
    static float currentX = -6f;
    public static int nombreBallon;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = new Vector3(currentX, 10f, 0.16f);
        Instantiate(ball, position, transform.rotation, maisonTransform);
        Destroy(other.gameObject);
        currentX += 3f;
        nombreBallon++;
    }



}

    