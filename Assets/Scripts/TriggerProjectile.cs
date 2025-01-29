using UnityEngine;

public class TriggerPorjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles = new GameObject[3];


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for ( int i = 0; i < projectiles.Length; i++ )
            {
                projectiles[i].SetActive(true);
            }

            Destroy(gameObject);
        }
    }
}
