﻿using UnityEngine;

public class playerCollision : MonoBehaviour{
    
public playerMovement movement;

    void OnCollisionEnter(Collision colInfo) {
        if(colInfo.collider.tag == "tree"){
        movement.enabled = false;
        }
    }

}
