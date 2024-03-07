using UnityEngine;


// Este script mostra a criação de variáveis básicas, assim como realiza uma soma no início do jogo e outra quando aperta o botão "espaço".

public class basicVariables : MonoBehaviour
{

    public int numeroInteiroA;
    public int numeroInteiroB;
    public int somaNumeroInteiro;

    public int somaNumeroInteiroConstante;

    public float numeroFracionadoA;
    public float numeroFracionadoB;
    public float somaNumeroFracionado;

    // Start is called before the first frame update
    void Start()
    {

        numeroInteiroA = 2;
        numeroInteiroB = 3;

        somaNumeroInteiro = numeroInteiroA + numeroInteiroB;
        Debug.Log(somaNumeroInteiro);


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {

            numeroFracionadoA = 1.5f;
            numeroFracionadoB = 2.6f;

            somaNumeroFracionado = numeroFracionadoA + numeroFracionadoB;
            Debug.Log(somaNumeroFracionado);

            somaNumeroInteiroConstante++;
            Debug.Log(somaNumeroInteiroConstante);

        }


    }
}
