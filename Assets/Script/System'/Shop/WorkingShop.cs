using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkingShop : MonoBehaviour
{
    [SerializeField] MoneyCollect spending;
    [SerializeField] Hunger hungry;
    [SerializeField] float hungerMetre = 0;

    public int cost;
    public TextMeshProUGUI costing;

    private void Start()
    {
        costing.text = cost.ToString("$0");
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
