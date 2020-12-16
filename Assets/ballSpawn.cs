using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pickup;

public class ballSpawn : MonoBehaviour
{

    [SerializeField]
    GameObject Ballon;


    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = transform.position + transform.forward * 1f;
        Instantiate(Ballon, position, transform.rotation);
    }
}
