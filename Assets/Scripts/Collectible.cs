using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // If the player collides with the object, it calls the singleton and updates it
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(1000, 0);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(1000, 0);
            Destroy(gameObject);
        }
    }
}
