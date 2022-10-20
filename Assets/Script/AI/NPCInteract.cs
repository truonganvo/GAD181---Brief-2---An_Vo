using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteract : MonoBehaviour
{
    [SerializeField] MoneyCollect playerRegister;

    public void Interact()
    {
        Debug.Log("Interact!");
        playerRegister.Money();
        playerRegister.Charisma();
    }
}
