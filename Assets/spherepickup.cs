﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherepickup : MonoBehaviour
{
    public KeyCode pickupButton = KeyCode.E;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Destroy(gameObject);
        }
    }
}
