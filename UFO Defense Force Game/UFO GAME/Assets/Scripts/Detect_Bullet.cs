using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Bullet : MonoBehaviour
{
    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        Instantiate(pickupEffect, transform.position, transform.rotation);
    }

}
