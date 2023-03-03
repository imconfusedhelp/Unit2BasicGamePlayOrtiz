using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // "when trigger is entered..."
    private void OnTriggerEnter(Collider other)
    {
        // destroy animal on collision
        Destroy(gameObject);

        // destroy projectile on collision
        Destroy(other.gameObject);
    }
}
