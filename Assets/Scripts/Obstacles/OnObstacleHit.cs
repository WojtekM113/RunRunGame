using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnObstacleHit : MonoBehaviour, ITrigger
{
    public void TriggerObject() {
        Debug.Log("Collision!");
        SceneManager.LoadScene("SampleScene");
    }

    
 
}

   






