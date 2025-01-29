using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3.0f; // Seconds.

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;   // Hide.
        rigidbody.useGravity = false;   // Float.
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            Debug.Log("Drop the beat!");
            meshRenderer.enabled = true;   // Show.
            rigidbody.useGravity = true;   // Fall.
        }
    }
}
