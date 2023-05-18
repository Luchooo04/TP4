using UnityEngine;

public class ChangeColor2 : MonoBehaviour
{
    public Color targetColor;
    public float downwardForce = 5f;
    public float upwardForce = 5f;

    private Renderer rend;
    private Color originalColor;
    private bool isColorChanged = false;
    private Rigidbody rb;
    private bool hasGravity = false;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void Update()
    {
        if (isColorChanged && hasGravity)
        {
            rb.AddForce(Vector3.down * downwardForce, ForceMode.Acceleration);
        }
    }

    private void OnMouseDown()
    {
        if (!isColorChanged)
        {
            rend.material.color = targetColor;
            isColorChanged = true;
            hasGravity = true;
            rb.useGravity = true;
        }
        else
        {
            rend.material.color = originalColor;
            isColorChanged = false;
            hasGravity = false;
            rb.useGravity = false;
            rb.AddForce(Vector3.up * upwardForce, ForceMode.Impulse);
        }
    }
}
