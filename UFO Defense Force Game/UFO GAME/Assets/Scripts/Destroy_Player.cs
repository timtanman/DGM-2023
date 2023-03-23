using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Player : MonoBehaviour
{

    public GameObject pickupEffect;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            Destroy(other.gameObject);
            Instantiate(pickupEffect, transform.position, transform.rotation);
        }
}
