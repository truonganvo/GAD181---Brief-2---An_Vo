using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] MoneyCollect enoughMoney;
    public void RestarButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("UI");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enoughMoney.moneyGain > 300)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
