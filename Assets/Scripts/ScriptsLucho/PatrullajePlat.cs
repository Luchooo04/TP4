using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullajePlat : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    public float distancia = 10f; // Distancia total que el objeto recorre de derecha a izquierda

    private float inicioX; // Posici�n inicial en el eje X
    private bool moverDerecha = true; // Bandera para indicar la direcci�n del movimiento

    private void Start()
    {
        inicioX = transform.position.x; // Guardar la posici�n inicial en el eje X
    }

    private void Update()
    {
        // Calcular la nueva posici�n en el eje X
        float nuevaPosicionX = transform.position.x + (moverDerecha ? velocidad : -velocidad) * Time.deltaTime;

        // Verificar si se alcanz� el l�mite de distancia
        if (Mathf.Abs(nuevaPosicionX - inicioX) >= distancia)
        {
            // Cambiar la direcci�n del movimiento
            moverDerecha = !moverDerecha;
        }

        // Actualizar la posici�n del objeto
        transform.position = new Vector3(nuevaPosicionX, transform.position.y, transform.position.z);
    }
}
