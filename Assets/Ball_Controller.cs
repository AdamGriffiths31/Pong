using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody2D Rb;
    public GameObject Bat1;
    public GameObject Bat2;
    // Start is called before the first frame update
    void Start()
    {
        Count_Score.CanAdd = true;
        Rb = this.GetComponent<Rigidbody2D>();
        StartCoroutine(Pause());
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x >= 30)
        {
            Count_Score.CanAdd = true;
            this.transform.position = new Vector3(0,0,0);
            StartCoroutine(Pause());
        }
        if (this.transform.position.x <= -30)
        {
            Count_Score.CanAdd = true;
            this.transform.position = new Vector3(0, 0, 0);
            StartCoroutine(Pause());
        }
    }
    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);
        if (directionX == 0)
        {
            directionX = 1;
        }
        Rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        Rb.velocity = new Vector2(15f*directionX, 15f * directionY);

    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.name == "Bat_1")
        {
            if (Bat1.GetComponent<Rigidbody2D>().velocity.y>0.5f)
            {
                Rb.velocity = new Vector2(15f, 15f);
            }
            else if (Bat1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                Rb.velocity = new Vector2(15f, -15f);
            }
            else
            {
                Rb.velocity = new Vector2(20f, 0f );
            }

        }
        if (hit.gameObject.name == "Bat_2")
        {
            if (Bat2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                Rb.velocity = new Vector2(-15f, 15f);
            }
            else if (Bat2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                Rb.velocity = new Vector2(-15f, -15f);
            }
            else
            {
                Rb.velocity = new Vector2(-20f, 0f);
            }
        }
    }
}
