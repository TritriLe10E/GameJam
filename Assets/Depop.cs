using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depop : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
