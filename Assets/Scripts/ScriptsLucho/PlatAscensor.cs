using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatAscensor : MonoBehaviour
{
 
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    public float distancia = 10f; // Distancia total que el objeto recorre de arriba a abajo

    private float inicioY; // Posición inicial en el eje Y
    private bool moverArriba = true; // Bandera para indicar la dirección del movimiento

    private void Start()
    {
        inicioY = transform.position.y; // Guardar la posición inicial en el eje Y
    }

    private void Update()
    {
        // Calcular la nueva posición en el eje Y
        float nuevaPosicionY = transform.position.y + (moverArriba ? velocidad : -velocidad) * Time.deltaTime;

        // Verificar si se alcanzó el límite de distancia
        if (Mathf.Abs(nuevaPosicionY - inicioY) >= distancia)
        {
            // Cambiar la dirección del movimiento
            moverArriba = !moverArriba;
        }

        // Actualizar la posición del objeto
        transform.position = new Vector3(transform.position.x, nuevaPosicionY, transform.position.z);
    }
}


