using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetActive : CoinCounter
{
    public GameObject door;

    public override void OpenDoorBcCoins(GameObject playerObject)
    {
        door = GetComponent<GameObject>();
        playerObject.GetComponent<CoinCounter>();

        if (currentNumberOfCoins == 5)
        {
            door.SetActive(false);
        }
    }
}