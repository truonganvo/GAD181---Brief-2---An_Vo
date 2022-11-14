using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    [SerializeField] AudioSource footstep;

    private void Stepping()
    {
        //Check if the player press the keyboard
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footstep.enabled = true;
        }
        else
        {
            footstep.enabled = false;
        }
    }
}
