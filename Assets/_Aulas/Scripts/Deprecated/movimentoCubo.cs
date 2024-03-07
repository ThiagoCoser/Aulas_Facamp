using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCubo : MonoBehaviour
{

    void movimentoEsquerda()
    {
        if (gameObject.transform.position.x <= 3 && gameObject.transform.position.x > -3)
        {

            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 3, gameObject.transform.position.y, gameObject.transform.position.z);



        }
    }

    void movimentoDireita()
    {
        if (gameObject.transform.position.x >= -3 && gameObject.transform.position.x < 3)
        {

            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 3, gameObject.transform.position.y, gameObject.transform.position.z);



        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movimentoEsquerda();



        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movimentoDireita();
        }



    }
}
