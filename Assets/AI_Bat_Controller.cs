using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Bat_Controller : MonoBehaviour
{
    private Rigidbody2D Rb;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
        Ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Ball.transform.position.y - transform.position.y;
        if(direction>1)
        {
            Rb.velocity = new Vector2(0f, 12f);
        }
        else if(direction<1)
        {
            Rb.velocity = new Vector2(0f, -12f);
        }
        else
        {
            Rb.velocity = new Vector2(0f, 0f);
        }
    }
}
