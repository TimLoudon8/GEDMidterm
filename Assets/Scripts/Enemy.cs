using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // If the player collides with the object, it calls the singleton and updates it
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(0, 1000);
            Debug.Log("Lost a life!");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(0, 1000);
            Debug.Log("Lost a life!");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(0, 1000);
            Debug.Log("Lost a life!");
            Destroy(gameObject);
        }
    }
}
