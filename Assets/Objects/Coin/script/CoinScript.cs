using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour, ITrigger {


    float blendTreeParameter = 0;


    public CoinsListScriptableObj coinsListScriptableObj;
    public void TriggerObject() {
        Debug.Log("CollectedCoin");
        coinsListScriptableObj.Coins.Add(1);
        DOTween.Kill(transform);
        Destroy(this.gameObject);
    }

    void Start() {
        //animation
        DOTween.To(() => blendTreeParameter, (x) => blendTreeParameter = x, .5f, .5f);


        transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.FastBeyond360)
      .SetLoops(-1, LoopType.Restart)
      .SetRelative()
      .SetEase(Ease.Linear);

        coinsListScriptableObj.Coins.Clear();
  
    }
}
