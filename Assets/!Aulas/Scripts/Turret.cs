using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    // Velocidade de rotação
    public float rotationSpeed = 5f;

    // Atualizar a cada quadro
    void Update()
    {
        // Obter a posição do mouse no mundo
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // Garantir que o mouse esteja na mesma profundidade que o objeto

        // Calcular a direção do mouse em relação ao objeto
        Vector3 direction = mousePos - transform.position;

        // Calcular o ângulo de rotação
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Criar uma rotação para olhar na direção do mouse
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Aplicar suavemente a rotação
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }


}
