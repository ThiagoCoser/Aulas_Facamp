using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D6_3D : MonoBehaviour
{

    public bool podeD6;


    private void Start()
    {
        podeD6 = true;
    }


    void podeD6Voltar()
    {
        podeD6 = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (Input.GetKey(KeyCode.Space) && podeD6 == true)
        {
            podeD6 = false;

            gameObject.GetComponent<Rigidbody>().AddForce(0, 3, 0, ForceMode.Impulse);
            gameObject.GetComponent<Rigidbody>().AddTorque(Random.Range(0.0f, 3f), Random.Range(0.0f, 3f), Random.Range(0.0f, 3f), ForceMode.Impulse);
            Invoke("podeD6Voltar", 3f);
        }
    }
}
