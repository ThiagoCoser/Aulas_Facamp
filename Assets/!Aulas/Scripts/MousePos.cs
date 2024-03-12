using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    public GameObject objetoParaInstanciar;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {


            // Obtém a posição atual do mouse na tela
            Vector3 posicaoMouse = Input.mousePosition;
            // Converte a posição do mouse de coordenadas de tela para coordenadas do mundo
            posicaoMouse = Camera.main.ScreenToWorldPoint(posicaoMouse);
            // Define a posição Z do objeto para 0, ou seja, na frente da câmera
            posicaoMouse.z = 0;
            // Instancia o objeto na posição do mouse
            Instantiate(objetoParaInstanciar, posicaoMouse, Quaternion.identity);
        }

    }



}
