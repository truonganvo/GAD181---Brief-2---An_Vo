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
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                //show the shop canvas
                Shop.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
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
