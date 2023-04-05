using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 11.0f;
    public float turnSpeed = 200.0f;
    public float horizontalInput;
    public float forwardInput;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");

        if (Input.GetAxis("Jump") == 1 && forwardInput < 1 && forwardInput > 0)
        {
            transform.Rotate(Vector3.right, -100 * Time.deltaTime);
        }

        if (forwardInput < 0)
            horizontalInput *= -1;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        if(forwardInput != 0)
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
