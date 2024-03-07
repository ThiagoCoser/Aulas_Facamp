using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D6_2D : MonoBehaviour
{

    //Este script criam uma função para sortear um número aleatório entre 1 e 6 e troca a textura do material de um objeto, quando o espaço é apertado e solto.

    public int D6Value;
    public Texture[] texturas;

    void D6()
    {
        D6Value = Random.Range(1, 7);
        gameObject.GetComponent<Renderer>().material.mainTexture = texturas[D6Value];
        Debug.Log(D6Value);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {

            D6();

        }
    }

}
