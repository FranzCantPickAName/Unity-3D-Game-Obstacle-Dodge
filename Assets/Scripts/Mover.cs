using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0f;
    float yValue = 0.05f;
    float zValue = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.01f, 0f, 0f);
        transform.Translate(xValue, yValue, zValue);
    }
}
