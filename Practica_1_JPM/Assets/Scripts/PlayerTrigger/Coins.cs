using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        CoinCounter coinCounter = playerObject.GetComponent<CoinCounter>();
        coinCounter.GetCoins(amountToGive);
        gameObject.SetActive(false);
    }
}