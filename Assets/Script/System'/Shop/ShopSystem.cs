using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSystem : MonoBehaviour
{
    public Canvas Shop;
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

            if(Shop.enabled == true)
            {
                if (Input.GetKey(KeyCode.Q))
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Shop.enabled = false;
                }
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
}
