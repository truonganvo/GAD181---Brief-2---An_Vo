using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource ClickSound;

    public void playSoundEffect()
    {
        ClickSound.Play();
    }
}
