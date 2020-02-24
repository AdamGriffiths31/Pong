using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels_Controller : MonoBehaviour
{
    public static bool OnePlayer = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerToggle()
    {
        OnePlayer = !OnePlayer;
    }
    public void DefaultLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void WhiteBlockLevel()
    {
        SceneManager.LoadScene(6);
    }
    public void WhiteCircleLevel()
    {
        SceneManager.LoadScene(7);
    }
}
