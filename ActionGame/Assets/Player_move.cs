﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 5);
        }
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 4, -30);
        }
    }

        void OnCollisionStay(Collision hit)
        {
            if(hit.gameObject.tag == "Enemy")
            {
                transform.position = new Vector3(0, 4, -30);
            }
        }
    
}
