using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RestarButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("UI");
    }
}
