using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkingShop : MonoBehaviour
{
    [SerializeField] MoneyCollect spending;
    [SerializeField] Hunger hungry;

    public int cost;
    public float fill;
    public TextMeshProUGUI costing;
    public TextMeshProUGUI full;
    private void Start()
    {
        costing.text = cost.ToString("$0");
        full.text = fill.ToString("0");
    }
    public void BuyingItem()
    {
        if (spending.moneyGain >= cost)
        {
            spending.moneyGain -= cost;
            hungry.hunger += fill;
        }
    }
}
