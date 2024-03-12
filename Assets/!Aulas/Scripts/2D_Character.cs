using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    private Rigidbody2D rb;
    public float velocidade;
    public float jumpValue;

    public Animator GhostAnimator;


    // Start is called before the first frame update
    void Start()
    {
        velocidade = 0.3f;
        // jumpValue = 1f;
        rb = gameObject.GetComponent<Rigidbody2D>();
        GhostAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX * velocidade, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, dirY * velocidade);


        if (dirX < 0 && dirY == 0)
        {
            GhostAnimator.Play("GhostLeft");
        }

        if (dirX > 0 && dirY == 0)
        {
            GhostAnimator.Play("GhostRight");
        }

        if (dirY > 0)
        {
            GhostAnimator.Play("GhostUp");
        }


        else if (dirX == 0)
        {
            GhostAnimator.Play("GhostIdle");
        }




        if (Input.GetButton("Jump"))

        {

            //   rb.velocity = new Vector2(rb.velocity.x, jumpValue);
        }


    }
}
