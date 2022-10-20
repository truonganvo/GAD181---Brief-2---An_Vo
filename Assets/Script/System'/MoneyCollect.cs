using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoneyCollect : MonoBehaviour
{
    //amount & spend
    public int moneyGain = 0;
    public TextMeshProUGUI moneyHave;

    //stats
    [SerializeField] int playerCharms = 0;

    private void Update()
    {
        moneyHave.text = moneyGain.ToString("0");
    }
    public void Charisma()
    {
        playerCharms += 1;
    }

    public void Money()
    {
        moneyGain += 10;
    }
}
