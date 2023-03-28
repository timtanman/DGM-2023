using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_touching : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Ignore collisions between objects with the "Enemy" tag
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }
}
