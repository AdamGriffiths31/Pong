using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu_Controller : MonoBehaviour
{
    public Button Play;
    public Button Quit;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void SinglePlayer()
    {
        SceneManager.LoadScene(4);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene(5);
    }
}
