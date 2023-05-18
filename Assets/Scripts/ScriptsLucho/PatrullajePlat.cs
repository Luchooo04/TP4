using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullajePlat : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    public float distancia = 10f; // Distancia total que el objeto recorre de derecha a izquierda

    private float inicioX; // Posición inicial en el eje X
    private bool moverDerecha = true; // Bandera para indicar la dirección del movimiento

    private void Start()
    {
        inicioX = transform.position.x; // Guardar la posición inicial en el eje X
    }

    private void Update()
    {
        // Calcular la nueva posición en el eje X
        float nuevaPosicionX = transform.position.x + (moverDerecha ? velocidad : -velocidad) * Time.deltaTime;

        // Verificar si se alcanzó el límite de distancia
        if (Mathf.Abs(nuevaPosicionX - inicioX) >= distancia)
        {
            // Cambiar la dirección del movimiento
            moverDerecha = !moverDerecha;
        }

        // Actualizar la posición del objeto
        transform.position = new Vector3(nuevaPosicionX, transform.position.y, transform.position.z);
    }
}
