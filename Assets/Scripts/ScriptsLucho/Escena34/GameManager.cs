using UnityEngine;

public class GameManager: MonoBehaviour
{
    public Transform  referencePlane;
    public GameObject redObject;
    public GameObject blueObject;

    private int redCount = 0;
    private int blueCount = 0;

    private void Start()
    {
        CountObjects();
    }
    private void Update()
    {
        CountObjects();
    }
    private void CountObjects()
    {
        redCount = 0;
        blueCount = 0;

        GameObject[] objects = GameObject.FindObjectsOfType<GameObject>();

        foreach (GameObject obj in objects)
        {
            if (obj != gameObject) // Exclude this script's game object
            {
                if (obj.CompareTag("Red"))
                {
                    // Check if object is above reference plane
                    if (obj.transform.position.y > referencePlane.position.y)
                    {
                        redCount++;
                    }
                }
                else if (obj.CompareTag("Blue"))
                {
                    // Check if object is below reference plane
                    if (obj.transform.position.y < referencePlane.position.y)
                    {
                        blueCount++;
                    }
                }
            }
        }

        Debug.Log("Red objects above: " + redCount);
        Debug.Log("Blue objects below: " + blueCount);
    }

   
}