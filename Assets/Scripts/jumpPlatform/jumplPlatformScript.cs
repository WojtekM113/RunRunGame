using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumplPlatformScript : MonoBehaviour, ITrigger   {

    public PlayerAddForceScriptableObject playerAddForce;
    public Rigidbody playerRigidBody;


 
    public void TriggerObject() {
        playerRigidBody.velocity = (Vector3.up * playerAddForce.addForce);
    }

    void Awake() {
 
       playerRigidBody = playerRigidBody.GetComponent<Rigidbody>();

    }
 
     
   
    
 
}

