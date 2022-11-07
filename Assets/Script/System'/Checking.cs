using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checking : MonoBehaviour
{
    [SerializeField] MoneyCollect Check;
    [SerializeField] private Animator anim;

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
        }
    }

    private void Track()
    {
        if (Check.playerCharms >= 10 && Check.moneyGain >= 10000)
        {
            anim.SetBool("playerImpact", true);
        }
    }
}
