using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hunger : MonoBehaviour
{
    public Slider hungerBar;

    public float hunger;
    float fullHunger = 100f;

    void Start()
    {
        hunger = fullHunger;
    } 

    void Update()
    {
        hungerBar.value = hunger;
        hunger -= 0.8f * Time.deltaTime;

        if (hunger <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
