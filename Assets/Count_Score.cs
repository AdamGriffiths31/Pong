using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject Ball;

    public static bool CanAdd = true;

    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.x >= 29 && CanAdd==true)
        {
            CanAdd = false;
            Bat_1_Score++;
        }
        if (Ball.transform.position.x <= -29 && CanAdd == true)
        {
            CanAdd = false;
            Bat_2_Score++;
        }
        if(Bat_1_Score >=5)
        {
            SceneManager.LoadScene(2);
        }
        if (Bat_2_Score >= 5)
        {
            SceneManager.LoadScene(3);
        }
        Scoreboard.text = Bat_1_Score.ToString() + ":" + Bat_2_Score.ToString();
    }
}
