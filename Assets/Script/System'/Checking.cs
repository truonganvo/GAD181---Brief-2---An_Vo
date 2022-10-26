using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checking : MonoBehaviour
{
    [SerializeField] MoneyCollect Check;

    private void Awake()
    {
        Check.GetComponent<MoneyCollect>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Track();
        }
    }
    private void Track()
    {
        if (Check.playerCharms >= 10 && Check.moneyGain >= 1000)
        {
            Destroy(gameObject);
        }
    }
}
