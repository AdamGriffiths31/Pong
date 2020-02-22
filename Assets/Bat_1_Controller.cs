using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_1_Controller : MonoBehaviour
{
    private Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
}
