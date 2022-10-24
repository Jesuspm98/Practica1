using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : PlayerTrigger
{
    public int dmgAmount = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        PlayerHealth health = playerObject.GetComponent<PlayerHealth>();
        health.TakeDmg(dmgAmount);
    }
}