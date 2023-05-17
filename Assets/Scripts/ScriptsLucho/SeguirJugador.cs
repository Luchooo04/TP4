using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador;
    public float suavidad = 0.5f;
    public Vector3 offset;

    private void LateUpdate()
    {
        if (jugador != null)
        {
            Vector3 destino = jugador.position + offset;
            Vector3 posicionSuavizada = Vector3.Lerp(transform.position, destino, suavidad);
            transform.position = posicionSuavizada;
        }
    }
}
