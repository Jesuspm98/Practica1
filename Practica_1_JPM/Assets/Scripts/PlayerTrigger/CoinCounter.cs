using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoins;

    public Text amountCounterText;

    private void Start()
    {
        amountCounterText.text = currentNumberOfCoins.ToString();
    }

    public void GetCoins(int coinAmount)
    {
        amountCounterText.text = currentNumberOfCoins.ToString();

        currentNumberOfCoins += coinAmount;
        if (currentNumberOfCoins == 1)
        {
            Debug.Log("Has recogido una moneda, tienes: " + currentNumberOfCoins + " moneda.");
            amountCounterText.text = currentNumberOfCoins.ToString();
        }
        else
        {
            Debug.Log("Has recogido una moneda, tienes: " + currentNumberOfCoins + " monedas.");
            amountCounterText.text = currentNumberOfCoins.ToString();
        }
    }
}