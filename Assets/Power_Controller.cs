using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Controller : MonoBehaviour
{
    public GameObject Bat1;
    public GameObject Bat2;
    public GameObject DownArrow;
    public GameObject BallSpeedUp;
    public GameObject WhiteSqaures;
    public GameObject Sqaure;
    public GameObject Sqaure1;

    public static bool PowerActive = false;
    public static bool WhiteSquaresActive = false;
    public static bool ShrinkActive = false;
    public static bool BallSpeedUpActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PowerActive == false)
        {
            PowerActive = true;
            var position = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0f);
            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(DownArrow);
            gameObjects.Add(BallSpeedUp);
            gameObjects.Add(WhiteSqaures);
            var power = gameObjects[Random.Range(0, gameObjects.Count)];
            power.transform.position = position;
        }
        if(ShrinkActive==true)
        {
            ShrinkActive = false;
            DownArrow.transform.position = new Vector2(40f, 15f);
            Bat2.transform.localScale = new Vector3(10, 10, 1);
            StartCoroutine(Reset());
        }
        if (BallSpeedUpActive == true)
        {
            BallSpeedUpActive = false;
            BallSpeedUp.transform.position = new Vector2(40f, 15f);
            Ball_Controller.BallSpeed = 25f;
            StartCoroutine(Reset());
        }
        if (WhiteSquaresActive == true)
        {
            WhiteSquaresActive = false;
            WhiteSqaures.transform.position = new Vector2(40f, 15f);
            Sqaure.SetActive(true);
            Sqaure1.SetActive(true);
            StartCoroutine(Reset());
        }
    }
    IEnumerator Reset()
    {
        yield return new WaitForSeconds(8);
        Bat2.transform.localScale = new Vector3(22, 22, 1);
        Ball_Controller.BallSpeed = 15f;
        Sqaure.SetActive(false);
        Sqaure1.SetActive(false);
        print("Reset");
        PowerActive = false;
    }


    

}
