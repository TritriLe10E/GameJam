using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decolage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BallonLaHaut.nombreBallon >= 5)
        {
            transform.position += Vector3.up * 2f * Time.deltaTime;
        }
        
    }
}
