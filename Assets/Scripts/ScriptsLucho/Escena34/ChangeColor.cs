using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color targetColor;
    public float upwardForce = 5f;

    private Renderer rend;
    private Color originalColor;
    private bool isColorChanged = false;
    private Rigidbody rb;
    private bool hasGravity = true;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isColorChanged && !hasGravity)
        {
            rb.AddForce(Vector3.up * upwardForce, ForceMode.Acceleration);
        }
    }

    private void OnMouseDown()
    {
        if (!isColorChanged)
        {
            rend.material.color = targetColor;
            isColorChanged = true;
            hasGravity = false;
            rb.useGravity = false;
        }
        else
        {
            rend.material.color = originalColor;
            isColorChanged = false;
            hasGravity = true;
            rb.useGravity = true;
        }
    }
}
