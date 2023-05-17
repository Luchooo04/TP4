using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPelota : MonoBehaviour
{
    public GameObject objetoPrefab;
    public float tiempoEntreInstancias = 2f;

    private GameObject instanciaActual;

    void Start()
    {
        InvokeRepeating("SpawnObject", tiempoEntreInstancias, tiempoEntreInstancias);
    }

    void SpawnObject()
    {
        if (instanciaActual != null)
        {
            Destroy(instanciaActual);
        }

        instanciaActual = Instantiate(objetoPrefab, transform.position, transform.rotation);
    }
}
