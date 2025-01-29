using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ()
    {
        PrintInstruction();
    }


    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void PrintInstruction ()
    {
        Debug.Log("Welcome!");
    }


    void Move ()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }
}
