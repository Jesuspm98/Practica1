using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOpen : CoinCounter
{
    public override void OpenDoorBcCoins(GameObject gameObject)
    {
        GameObject gameObject1 = gameObject.GetComponent<GameObject>();

        if (currentNumberOfCoins == 5)
        {
            gameObject.SetActive(false);
        }
    }
}