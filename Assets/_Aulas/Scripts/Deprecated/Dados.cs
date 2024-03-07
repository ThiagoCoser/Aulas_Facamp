using UnityEngine;

public class Dados : MonoBehaviour
{


    public int D6Value;
    public Texture[] texturas;

    void D6()
    {
        D6Value = Random.Range(1, 7);
        gameObject.GetComponent<Renderer>().material.mainTexture = texturas[D6Value];
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
