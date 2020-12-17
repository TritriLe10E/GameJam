using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMove : MonoBehaviour
{
    Rigidbody rigidbody;
    float positionDeBase;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        positionDeBase = transform.position.x;
    }
    Vector3 direction = new Vector3(1f, 0f, 0f);
    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;

        float speed = 2f;






        if (transform.position.x >= positionDeBase + 2f)
        {
            direction = new Vector3(-1f, 0f, 0f);
        }

        if (transform.position.x <= positionDeBase + -2f)
        {
            direction = new Vector3(1f, 0f, 0f);
        }

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        rigidbody.MovePosition(newPosition);
    }
}
