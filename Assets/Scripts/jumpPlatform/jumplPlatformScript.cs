using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumplPlatformScript : MonoBehaviour, ITrigger   {

    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject target;
    private Rigidbody playerRigidbody;

    private float jumpFallSpeed = 1f;

    public void TriggerObject() {
     // playerRigidbody.DOJump(transform.position + new Vector3(5,0,0), 3, 1, 0.5f, false);
        playerRigidbody.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
    }
    
    void Awake() {
 
       playerRigidbody = player.GetComponent<Rigidbody>();

    }
 
     
    
    
 
}

