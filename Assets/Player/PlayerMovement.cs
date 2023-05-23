using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour { 
 
    private float[] positionAxisZ = new float[] {3, 0, -3};
    int PositionAxisZXIndex = 1;

    float height = 1;

    float speedOfThePlayer = 10;

    private Rigidbody playerRigidbody;

    private void MoveLeft() {

        PositionAxisZXIndex--;
        if (PositionAxisZXIndex < 0) {
            PositionAxisZXIndex = 0;
        }
 
    }
    private void MoveRight() {
        PositionAxisZXIndex++;
        if (PositionAxisZXIndex > positionAxisZ.Length - 1) {
            PositionAxisZXIndex = 2;
        }
    }


    void  Update() {
        float horizontal = Input.GetAxis("Horizontal");
 

        //zmieniæ na input system

         
          if (Input.GetKeyDown(KeyCode.A)) {
             MoveLeft();
         }
         if (Input.GetKeyDown(KeyCode.D)) {
             MoveRight();

         }
         
        //playerRigidbody.MovePosition(transform.position + new Vector3(1, 0, -horizontal) * 10f * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,height,(positionAxisZ[PositionAxisZXIndex])), Time.deltaTime * 10f) ; 
    }

    private void FixedUpdate() {
     

        float horizontalInput = Input.GetAxis("Horizontal");                    
        float moveForward =  transform.position.x + 1 * speedOfThePlayer * Time.deltaTime;
        float moveHorizontal = Mathf.Clamp(transform.position.z + -horizontalInput * 10f * Time.deltaTime,-3,3);

 
         // playerRigidbody.MovePosition(new Vector3(moveForward, transform.position.y,   positionAxisZ[PositionAxisZXIndex])); or\/
           playerRigidbody.MovePosition(new Vector3(moveForward, transform.position.y,moveHorizontal));
 
    }

    private void Start() {
        
        playerRigidbody = GetComponent<Rigidbody>();

    }
}




