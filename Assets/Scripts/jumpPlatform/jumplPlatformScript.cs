using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumplPlatformScript : MonoBehaviour, ITrigger   {

    
    [SerializeField] private GameObject player;
    
    private Rigidbody playerRigidbody;

    [SerializeField] private PlayerAddForceScriptableObject force;

    public void TriggerObject() {
      
        playerRigidbody.AddForce(new Vector3(0,force.addForce,0), ForceMode.Impulse);
    }
    
    void Awake() {
 
       playerRigidbody = player.GetComponent<Rigidbody>();

    }
 
     
    
    
 
}

