using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteract : MonoBehaviour
{
    [SerializeField] MoneyCollect playerRegister;
    public int moneyCollecting = 0;

    private bool cooldownBetween = false;
    [SerializeField] AudioSource moneySFX;
    public void Interact()
    {
        if(cooldownBetween == false)
        {
            playerRegister.moneyGain += moneyCollecting;
            Debug.Log("Interact!");
            playerRegister.Charisma();

            Invoke("ResetCoolDown", 30f);
            cooldownBetween = true;
            moneySFX.Play();
        }
    }

    void ResetCoolDown()
    {
        cooldownBetween = false;
    }
}
