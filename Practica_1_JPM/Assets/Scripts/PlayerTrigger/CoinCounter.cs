using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoins;

    public Text amountCounterText;

    public GameObject doorBlock1;

    public GameObject doorBlock2;

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

        if (currentNumberOfCoins == 5)
        {
            doorBlock1.SetActive(false);

            Debug.Log("Oh, parece que se ha abierto algo...");
        }

        if (currentNumberOfCoins == 10)
        {
            doorBlock2.SetActive(false);

            Debug.Log("¡Tengo las 10 monedas, la última puerta se ha abierto!");
        }
    }
}