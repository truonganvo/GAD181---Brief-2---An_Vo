using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checking : MonoBehaviour
{
    [SerializeField] MoneyCollect Check;
    [SerializeField] private Animator anim;

    [SerializeField] Canvas notEnough;

    private void Awake()
    {
        Check.GetComponent<MoneyCollect>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Track();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("playerImpact", false);
            notEnough.enabled = false;
        }
    }

    private void Track()
    {
        if (Check.moneyGain >= 50)
        {
            anim.SetBool("playerImpact", true);
        }

        if (Check.moneyGain <= 50)
        {
            notEnough.enabled = true;
        }

        else
        {
            notEnough.enabled = false;
        }
    }
}
