using UnityEngine;

public class Reset : MonoBehaviour
{
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


}







