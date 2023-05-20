using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour { 
    // Start is called before the first frame update


    private float[] positionAxisZ = new float[] {3, 0, -3};
    int PositionAxisZXIndex = 1;

    float height = 1;

    
    

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
        transform.position += Vector3.right * 10.0f * Time.deltaTime;

        //zmieniæ na input system

        if (Input.GetKeyDown(KeyCode.A)) {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            MoveRight();

        }
       
        
    

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,height,(positionAxisZ[PositionAxisZXIndex])), Time.deltaTime * 10f) ; 
    }

    


}




