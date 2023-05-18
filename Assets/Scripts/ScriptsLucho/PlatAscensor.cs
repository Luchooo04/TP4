using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatAscensor : MonoBehaviour
{
 
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    public float distancia = 10f; // Distancia total que el objeto recorre de arriba a abajo

    private float inicioY; // Posici�n inicial en el eje Y
    private bool moverArriba = true; // Bandera para indicar la direcci�n del movimiento

    private void Start()
    {
        inicioY = transform.position.y; // Guardar la posici�n inicial en el eje Y
    }

    private void Update()
    {
        // Calcular la nueva posici�n en el eje Y
        float nuevaPosicionY = transform.position.y + (moverArriba ? velocidad : -velocidad) * Time.deltaTime;

        // Verificar si se alcanz� el l�mite de distancia
        if (Mathf.Abs(nuevaPosicionY - inicioY) >= distancia)
        {
            // Cambiar la direcci�n del movimiento
            moverArriba = !moverArriba;
        }

        // Actualizar la posici�n del objeto
        transform.position = new Vector3(transform.position.x, nuevaPosicionY, transform.position.z);
    }
}


