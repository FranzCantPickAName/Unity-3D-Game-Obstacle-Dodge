using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    //[SerializeField] float xValue = 0f;
    //[SerializeField] float yValue = 0.05f;
    //[SerializeField] float zValue = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //transform.Translate(0.01f, 0f, 0f);
        transform.Translate(xValue, yValue, zValue);
    }
}
