﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour{

    public Rigidbody rb;
    public float forwardForce = 10f;
    public float sidewaysForce = 2.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,-forwardForce*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -3f){
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
