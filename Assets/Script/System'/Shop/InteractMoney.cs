using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractMoney : MonoBehaviour
{
    [SerializeField] Canvas buttonDisplay;
    [SerializeField] MoneyCollect moneySystem;
    [SerializeField] int gather = 0;
    [SerializeField] TextMeshProUGUI costing;

    private bool cooldown = false;

    private void Update()
    {
        costing.text = gather.ToString("0");
    }
    public void GettingMoney()
    {
        if (cooldown == false)
        {
            moneySystem.moneyGain += gather;
            Invoke("ResetCoolDown", 120f);
            cooldown = true;
            buttonDisplay.enabled = false;
        }
    }

    void Coundownding()
    {
        cooldown = false;
        buttonDisplay.enabled = true;
    }
}
