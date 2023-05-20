using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour   {
   
    

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.GetComponent<ICollision>()!= null) {
             collision.collider.GetComponent<ICollision>().CollisionWithObstacle();
        
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<ITrigger>()!= null) {
            other.GetComponent<ITrigger>().TriggerObject();
            
        }
    }












}
