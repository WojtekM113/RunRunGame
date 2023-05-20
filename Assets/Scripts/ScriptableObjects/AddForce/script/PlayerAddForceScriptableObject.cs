using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "AddForce", menuName = "ScriptableObjects/AddForceObject", order = 1)]
public class PlayerAddForceScriptableObject : ScriptableObject
{
    public string prefabName;
    public float addForce = 0;

}
