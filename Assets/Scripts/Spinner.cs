using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float pitch = 0;
    [SerializeField] float yaw   = 0;
    [SerializeField] float roll  = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(pitch, yaw, roll);
    }
}
