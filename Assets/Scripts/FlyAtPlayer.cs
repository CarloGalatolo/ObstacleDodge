using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    public Vector3 targetPosition;
    [SerializeField] Transform player;
    [SerializeField] float speed = 1;


    // Fires before Start().
    private void Awake()
    {
        gameObject.SetActive(false);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPosition = player.position;
    }


    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();
    }


    void MoveTowardsPlayer ()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }


    void DestroyWhenReached ()
    {
        if ( transform.position == targetPosition )
        {
            Destroy(gameObject);
        }
    }
}
