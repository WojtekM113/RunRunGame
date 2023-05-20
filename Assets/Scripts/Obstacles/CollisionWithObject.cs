using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionWithObject : MonoBehaviour, ICollision
{


    void ICollision.CollisionWithObstacle() {
        Debug.Log("Collision!");
        SceneManager.LoadScene("SampleScene");
    }
}

   






