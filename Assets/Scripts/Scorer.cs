using UnityEngine;

public class Scorer : MonoBehaviour
{
    uint hits = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.tag != "Hit" )
        {
            Debug.Log("You've bumped into an obstacle this many times: " + ++hits);
            other.gameObject.tag = "Hit";
        }
    }
}
