using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    private Rigidbody2D rb;
    public float velocidade;
    public float jumpValue;


    // Start is called before the first frame update
    void Start()
    {
        velocidade = 1f;
        jumpValue = 1f;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * velocidade, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, dirY * velocidade);


        if (Input.GetButton("Jump"))

        {

            //   rb.velocity = new Vector2(rb.velocity.x, jumpValue);
        }


    }
}
