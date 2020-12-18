using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decolage : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    bool triggered = false;

    void Update()
    {
        if(BallonLaHaut.nombreBallon >= 5)
        {
            transform.position += Vector3.up * 2f * Time.deltaTime;
            if(!triggered)
            {
                triggered = true;
                cam.rect = new Rect(0f, 0f, 1f, 1f);
            }
        }
            
    }
}
