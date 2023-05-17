using UnityEngine;

public class ControlGravedad : MonoBehaviour
{
    public float gravedad = 9.8f; // Valor de gravedad personalizable

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Desactiva la gravedad predeterminada de Unity
    }

    private void FixedUpdate()
    {
        // Aplica la fuerza de gravedad al objeto en la dirección opuesta del eje Y
        Vector3 fuerzaGravedad = new Vector3(0, -gravedad * rb.mass, 0);
        rb.AddForce(fuerzaGravedad, ForceMode.Force);
    }
}