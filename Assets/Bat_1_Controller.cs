using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_1_Controller : MonoBehaviour
{
    public GameObject Ball;
    private Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
        Ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (Levels_Controller.OnePlayer == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Rb.velocity = new Vector2(0f, 10f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Rb.velocity = new Vector2(0f, -10f);

            }
            else
            {
                Rb.velocity = new Vector2(0f, 0f);

            }
        }
        else
        {
            var direction = Ball.transform.position.y - transform.position.y;
            if (direction > 1)
            {
                Rb.velocity = new Vector2(0f, 12f);
            }
            else if (direction < 1)
            {
                Rb.velocity = new Vector2(0f, -12f);
            }
            else
            {
                Rb.velocity = new Vector2(0f, 0f);
            }
        }
    }
}
