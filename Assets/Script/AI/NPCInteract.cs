using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteract : MonoBehaviour
{
    [SerializeField] MoneyCollect playerRegister;
    private bool cooldownBetween = false;
    public void Interact()
    {
        if(cooldownBetween == false)
        {
            Debug.Log("Interact!");
            playerRegister.Money();
            playerRegister.Charisma();

            Invoke("ResetCoolDown", 30f);
            cooldownBetween = true;
        }
    }

    void ResetCoolDown()
    {
        cooldownBetween = false;
    }
}
