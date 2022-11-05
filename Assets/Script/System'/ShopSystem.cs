using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSystem : MonoBehaviour
{
    public Canvas Shop;
    [SerializeField] MoneyCollect spending;
    [SerializeField] Hunger hungry;
    [SerializeField] float hungerMetre = 0;
    public int cost;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                //show the shop canvas
                Shop.enabled = true;
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            BuyingItem();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Shop.enabled = false;
        }
    }

    public void BuyingItem()
    {
        if (spending.moneyGain >= cost)
        {
            spending.moneyGain -= cost;
            hungry.hunger += hungerMetre;
        }
    }
}
