using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Coins", menuName = "ScriptableObjects/CoinsListScriptableObject")]
public class CoinsListScriptableObj : ScriptableObject
{
  public List<int> Coins = new List<int>();


}
