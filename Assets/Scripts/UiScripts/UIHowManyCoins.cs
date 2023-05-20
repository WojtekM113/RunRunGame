using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHowManyCoins : MonoBehaviour
{
    public CoinsListScriptableObj coinsListScriptableObj;


    [SerializeField] private TextMeshProUGUI textElement;
    string textValue;

    private void Update() {
        int coinsInList = coinsListScriptableObj.Coins.Count;

       textValue =  coinsInList.ToString();

       textElement.text = textValue;
    }

}
