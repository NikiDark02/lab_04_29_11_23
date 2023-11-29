using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpSpeed = 5;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity += new Vector2(jumpSpeed, jumpSpeed);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            rb.velocity += new Vector2(-jumpSpeed, jumpSpeed);
        }
    }
}
