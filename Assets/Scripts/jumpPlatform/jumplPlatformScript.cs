using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumplPlatformScript : MonoBehaviour, ITrigger   {

    public PlayerAddForceScriptableObject playerAddForce;
    public Rigidbody playerRigidBody;
    public GameObject player;

    private float jumpFallSpeed = 1f;

    public void TriggerObject() {
       // player.transform.DOJump(new Vector3(5, 5, 5),5,1,jumpFallSpeed,true);
        playerRigidBody.DOJump(new Vector3(5,5,0),5,1,jumpFallSpeed,true) ;
        //playerRigidBody.velocity = (Vector3.up * playerAddForce.addForce);
    }
    
    void Awake() {
 
      playerRigidBody = playerRigidBody.GetComponent<Rigidbody>();

    }
 
     
    
    
 
}

