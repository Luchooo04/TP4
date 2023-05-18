using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Reset : MonoBehaviour
{
    public TMPro.TMP_Text Completado;
     
    /*______________________________*/
    private  Vector3 originalPosition;

    private  void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetObjectPosition();
        }
    }

    private  void ResetObjectPosition()
    {
        transform.position = originalPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión es con el objeto deseado
        if (collision.gameObject.CompareTag("Meta"))
        {
            // Establece el texto deseado
            Completado.text = "COMPLETADO!";

            // Activa el objeto de texto para que sea visible
            Completado.gameObject.SetActive(true);
        }
    }

}







