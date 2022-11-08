using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtorialSystem : MonoBehaviour
{
    public Canvas Tutorial;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            {
                Tutorial.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Tutorial.enabled = false;
        }
    }
}
