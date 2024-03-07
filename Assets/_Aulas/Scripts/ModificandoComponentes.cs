using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModificandoComponentes : MonoBehaviour
{

    // Este script acessa diversos tipos de GameObjects na cena, de maneiras diferentes, e altera os atributos dos seus componentes no update.
    // criada, assim como a esfera, enquanto a luz e o som são procurados automaticamente pelo nome do Gameobject.



    public GameObject esfera3D;
    public GameObject cubo3D;
    public GameObject luzDirecional;
    public GameObject somDeMoeda;

    // Start is called before the first frame update
    void Start()
    {


        luzDirecional = GameObject.Find("LuzDirecional");
        somDeMoeda = GameObject.Find("Som");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {

            cubo3D.GetComponent<Transform>().position = new Vector3(-5, 0, 0);
            esfera3D.SetActive(false);
            somDeMoeda.GetComponent<AudioSource>().Play();
            luzDirecional.GetComponent<Light>().color = Color.magenta;

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            cubo3D.GetComponent<Transform>().position = new Vector3(0, 0, 0);
            esfera3D.SetActive(true);
            somDeMoeda.GetComponent<AudioSource>().Play();
            luzDirecional.GetComponent<Light>().color = Color.white;

        }

    }
}
