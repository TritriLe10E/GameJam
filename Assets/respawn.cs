using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 spawn;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -3)
        {
            transform.position = spawn;
        }

        Debug.Log(transform.position);
    }
}